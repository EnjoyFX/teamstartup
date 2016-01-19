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
            return new CallToActionEntity { FindYourJobDescription = "Smartup market is the best place to find a great freelance job or join the startup team to develop revolutionary technologies. It’s fast, fun and completely free for startups and candidates. Candidates can see salary and equity information upfront",
                LaunchStartupDescription = "On Smartup market over 200 consortiums including Dave Morin, Elad Gil and Foundry Group invest in fast growing companies for A, B, C rounds. Startups can find 40,000 new candidates a week — over half are engineers, designers or product managers",
                PostJobDescription = "Smartup Job market allows startups, employers and candidates to meet through simple, Tinder-like matching. It’s simply to hire qualified and professional talents to meet your job requirements",
                StartToInvestDescription = "Investors care about the team, the traction you’ve achieved so far, the size of the market you’re addressing, and the entry barriers you can create"
            };
        }
    }
}
