using Smart.BL.Entities;
using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.BL.Services.Concrete
{
    public class JobMarketService: IJobMarketService
    {
        #region IMarketService

        public IEnumerable<JobMarketEntity> GetMostPopular()
        {
            List<JobMarketEntity> markets = new List<JobMarketEntity>()
            {
                new JobMarketEntity() { Id = 1, Name = "Software" },
                new JobMarketEntity() { Id = 2, Name = "Consumer Internet" },
                new JobMarketEntity() { Id = 3, Name = "E-Commerce" },
                new JobMarketEntity() { Id = 4, Name = "Financial Service" },
                new JobMarketEntity() { Id = 5, Name = "Hardware" },
                new JobMarketEntity() { Id = 6, Name = "Healthcare" },
                new JobMarketEntity() { Id = 7, Name = "Entertainment" },
                new JobMarketEntity() { Id = 8, Name = "Education" }
            };

            return markets;
        }

        #endregion
    }
}