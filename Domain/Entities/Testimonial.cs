using Domain.Comman;

namespace Domain.Entities;

public class Testimonial : BaseEntity 
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
    public string ImageName { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }   

}
