
using Domain.Comman;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public interface IRepository<T>
    where T : BaseEntity
{
    DbSet<T> Table { get; }
}
