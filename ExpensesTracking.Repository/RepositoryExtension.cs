using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracking.Repository
{
    public static class RepositoryExtension
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services)
        {
            var dbFilePath = Path.Combine(FileSystem.AppDataDirectory, $"{nameof(ExpensesTracking)}.sqlite");
            services.AddDbContext<ExpensesDbContext>(opt => opt.UseSqlite($"File={dbFilePath}"));

            return services;
        }
    }
}
