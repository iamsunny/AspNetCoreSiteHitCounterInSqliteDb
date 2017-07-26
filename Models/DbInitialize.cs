using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HitCounter.Models
{
    public static class DbInitialize{
        public static void EnsureCreated(IServiceProvider serviceProvider){
            var context
             = new AppStateContext(serviceProvider.GetRequiredService<DbContextOptions<AppStateContext>>());
             context.Database.EnsureCreated();
        }
    }
}