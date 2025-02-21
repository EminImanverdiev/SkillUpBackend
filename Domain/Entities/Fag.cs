

using Domain.Comman;
using Domain.Enums;

namespace Domain.Entities;

public class Fag:BaseEntity
{
    public string Title { get; set; } 
    public string Content { get; set; }

    public FagType Type { get; set; } 
}