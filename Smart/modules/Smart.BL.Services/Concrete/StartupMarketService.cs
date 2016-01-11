using Smart.BL.Entities;
using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.BL.Services.Concrete
{
    public class StartupMarketService: IStartupMarketService
    {
        #region IMarketService

        public IEnumerable<StartupMarketEntity> GetMostPopular()
        {
            List<StartupMarketEntity> markets = new List<StartupMarketEntity>()
            {
                new StartupMarketEntity() { Id = 1, Name = "Software" },
                new StartupMarketEntity() { Id = 2, Name = "Consumer Internet" },
                new StartupMarketEntity() { Id = 3, Name = "E-Commerce" },
                new StartupMarketEntity() { Id = 4, Name = "Financial Service" },
                new StartupMarketEntity() { Id = 5, Name = "Hardware" },
                new StartupMarketEntity() { Id = 6, Name = "Healthcare" },
                new StartupMarketEntity() { Id = 7, Name = "Entertainment" },
                new StartupMarketEntity() { Id = 8, Name = "Education" }

            };

            return markets;
        }

        #endregion
    }
}