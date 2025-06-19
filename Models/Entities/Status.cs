using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Status
{
    public int StatusId { get; set; }
    public string Name { get; set; }

    // Navigation property
    public ICollection<Ticket> Tickets { get; set; }
}

