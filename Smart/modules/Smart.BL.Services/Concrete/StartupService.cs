using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.BL.Entities;

namespace Smart.BL.Services.Concrete
{
    public class StartupService : IStartupService
    {
        public IEnumerable<StartupEntity> GetTopRated()
        {
            List<StartupEntity> startups = new List<StartupEntity>()
            {
                new StartupEntity() { Id = 1, Name = "Startup-1" },
                new StartupEntity() { Id = 2, Name = "Startup-2" },
                new StartupEntity() { Id = 3, Name = "Startup-3" },
                new StartupEntity() { Id = 4, Name = "Startup-4" },
                new StartupEntity() { Id = 5, Name = "Startup-5" }
            };

            return startups;
        }
    }
}
