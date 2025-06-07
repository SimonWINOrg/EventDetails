using System.ComponentModel.DataAnnotations;

namespace EventDetailsPresentation.Data;

public class EventDetailsEntity
{
    
    [Key]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; } = null!; 
    public string DateTime { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Price { get; set; } = null!;
    public string Description { get; set; } = null!;
}

