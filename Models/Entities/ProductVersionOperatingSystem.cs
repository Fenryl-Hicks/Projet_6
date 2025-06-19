namespace Projet6.Models.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProductVersionOperatingSystem
    {
        public int Id { get; set; }

        // Foreign Keys
        public int ProductId { get; set; }
        public int VersionId { get; set; }
        public int OperatingSystemId { get; set; }

        // Navigation properties
        public Product Product { get; set; }
        public Version Version { get; set; }
        public OperatingSystem OperatingSystem { get; set; }

        // Navigation to Ticket
        public ICollection<Ticket> Tickets { get; set; }
    }

}
