using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence;

public static class PersistenceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services,IConfiguration configuraion)
    {
        services.AddDbContext<SkillUpDbContext>(options =>
        {
            options.UseNpgsql(configuraion.GetConnectionString("DbConnection"));
        });
    }
}
