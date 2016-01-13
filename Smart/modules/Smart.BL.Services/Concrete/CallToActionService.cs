using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.BL.Entities;

namespace Smart.BL.Services.Concrete
{
    public class CallToActionService : ICallToActionService
    {
        public CallToActionEntity GetDescription()
        {
            return new CallToActionEntity { FindYourJobDescription = "FindYourJobDescription",
                LaunchStartupDescription = "LaunchStartupDescription",
                PostJobDescription = "PostJobDescription",
                StartToInvestDescription = "StartToInvestDescription"
            };
        }
    }
}
