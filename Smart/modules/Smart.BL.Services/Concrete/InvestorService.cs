using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.BL.Entities;

namespace Smart.BL.Services.Concrete
{
    public class InvestorService : IInvestorService
    {
        public IEnumerable<InvestorEntity> GetNotableInvestors()
        {
            List<InvestorEntity> investors = new List<InvestorEntity>()
            {
                new InvestorEntity() { Id = 1, Name = "Lary Page" },
                new InvestorEntity() { Id = 2, Name = "Eric Schmidt" },
                new InvestorEntity() { Id = 3, Name = "Michael Bloomberg" },
                new InvestorEntity() { Id = 4, Name = "Warren Buffett" }
            };

            return investors;
        }
    }
}
