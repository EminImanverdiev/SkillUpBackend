using Domain.Comman;
using Domain.Enums;

namespace Domain.Entities;

public class Instructor : BaseEntity {

    public string Name { get; set; }
    public JobType Job { get; set; }
    public string Biography { get; set; }
    public string Description { get; set; }
    public int StudentCount { get; set; }

}
