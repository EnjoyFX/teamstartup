using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.BL.Entities
{
    public class Talent
    {
        public string PhotoUrl { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public string Title { get; set; }

        public int Rate { get; set; }

        public int PercentSuccess { get; set; }

        public int Jobs { get; set; }

        public int Availability { get; set; }

        public int ResponceTime { get; set; }

        public int Tests { get; set; }

        public int TestsSuccess { get; set; }

        public string Language { get; set; }

        public string LanguageLevel { get; set; }

        public string MemberOfCorporation { get; set; }

        public IEnumerable<string> Categories { get; set; }
    }
}
