using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace HitCounter.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider){
            using(var context = new AppStateContext(serviceProvider.GetRequiredService<DbContextOptions<AppStateContext>>())){
                if(context.AppStates.Any()){
                    return;
                }

                 context.AppStates.Add(new AppState() { Id = 1, HitCount = 0 });                
                
                context.SaveChanges();
            }
        }

    }
}
