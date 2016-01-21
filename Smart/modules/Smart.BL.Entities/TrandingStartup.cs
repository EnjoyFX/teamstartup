using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.BL.Entities
{
    public class TrandingStartup
    {
        public string Logo { get; set; }

        public string Title { get; set; }

        public Startuper Startuper { get; set; }

        public string Investor { get; set; }

        public int Founded { get; set; }

        public double Pladged { get; set; }

        public int Backers { get; set; }

        public int DaysToGo { get; set; }
    }
}
