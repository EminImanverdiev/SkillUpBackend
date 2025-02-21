

using Domain.Comman;

namespace Domain.Entities;

public class Service : BaseEntity
{

    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageURL { get; set; }
    public string ImageName { get; set; }
}
