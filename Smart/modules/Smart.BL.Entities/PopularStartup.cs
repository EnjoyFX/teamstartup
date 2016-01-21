using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.BL.Entities
{
    public class PopularStartup
    {
        public string Logo { get; set; }

        public string Title { get; set; }

        public Startuper Startuper { get; set; }

        public string Status { get; set; }

        public IEnumerable<string> Categories { get; set; }
    }
}
