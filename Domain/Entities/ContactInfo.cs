using Domain.Comman;

namespace Domain.Entities;

public class ContactInfo : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; } 
    public string Value { get; set; }  
    public string Icon { get; set; } 
    public short DisplayOrder { get; set; } 
}