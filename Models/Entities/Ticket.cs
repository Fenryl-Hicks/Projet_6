using Projet6.Models.Entities;

public class Ticket
{
    public int TicketId { get; set; }

    public int StatusId { get; set; }
    public DateTime DateCreation { get; set; }
    public DateTime? DateResolution { get; set; }


    public string ProblemText { get; set; }
    public string? ResolutionText { get; set; }


    // Foreign Keys


    public int ProductVersionOperatingSystemId { get; set; }

    // Navigation properties
    public Status Status { get; set; }
    public ProductVersionOperatingSystem ProductVersionOperatingSystem { get; set; }
}

