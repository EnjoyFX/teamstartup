using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.IC.Timing.Abstract;

namespace Smart.IC.Timing.Concrete
{
    public class TimeService : ITimeService
    {
        #region ITimeService Members

        public DateTime Now()
        {
            return DateTime.Now;
        }

        #endregion ITimeService Members

    }
}
