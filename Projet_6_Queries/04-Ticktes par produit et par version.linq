<Query Kind="Statements">
  <Connection>
    <ID>4ca58a30-917d-4f9b-bd50-d8788c92ab9a</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="EF7Driver" PublicKeyToken="469b5aa5a4331a8c">EF7Driver.StaticDriver</Driver>
    <CustomAssemblyPathEncoded>&lt;MyDocuments&gt;\Projet6\Projet6\bin\Debug\net8.0\Projet6.dll</CustomAssemblyPathEncoded>
    <CustomTypeName>Projet6.Data.MyDbContext</CustomTypeName>
    <CustomCxString>Server=(localdb)\mssqllocaldb;Database=Projet_6;Trusted_Connection=True;MultipleActiveResultSets=true</CustomCxString>
    <DriverData>
      <UseDbContextOptions>true</UseDbContextOptions>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

IQueryable<Ticket> GetTickets( 
    bool resolved, 
    int? productId = null, 
    int? versionId = null, 
    DateTime? start = null, 
    DateTime? end = null, 
    List<string>? keywords = null 
) 
{ 
    var query = Tickets 
        .Where(t => t.StatusId == (resolved ? 2 : 1)) // 2 = Résolu, 1 = En cours 
        .Where(t => productId == null || t.ProductVersionOperatingSystem.ProductId == productId) 
        .Where(t => versionId == null || t.ProductVersionOperatingSystem.VersionId == versionId) 
        .Where(t => start == null || t.DateCreation >= start) 
        .Where(t => end == null || t.DateCreation <= end); 

    if (keywords != null && keywords.Any()) 
    { 
        foreach (var word in keywords) 
        { 
            var w = word.ToLower(); 
    query = query.Where(t => t.ProblemText.ToLower().Contains(w)); 
        } 
    } 

    return query; 
} 
var productId = 3; 
var versionId = 5; 

var ticketsEnCours = GetTickets( 
    resolved: false, 
    productId: productId, 
    versionId: versionId 
); 

var ticketsResolus = GetTickets( 
    resolved: true, 
    productId: productId, 
    versionId: versionId 
); 

var allTickets = ticketsEnCours.Concat(ticketsResolus); 

allTickets.Dump();



