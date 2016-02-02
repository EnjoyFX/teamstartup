using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.BL.Entities
{
    public class StartupEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string LogoUrl { get; set; }

        public Startuper Startuper { get; set; }

        public string Status { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public string Investor { get; set; }

        public int InvestedFunds { get; set; }

        public decimal Pladged { get; set; }

        public int Backers { get; set; }

        public int DaysToGo { get; set; }

        public string BackTitle { get; set; }

        public string BackContent { get; set; }
    }
}
