using Domain.Comman;

namespace Domain.Entities;

public class Statistic:BaseEntity
{
    public int Count { get; set; }  
    public string Value { get; set; }  
    public short DisplayOrder { get; set; }  
}
