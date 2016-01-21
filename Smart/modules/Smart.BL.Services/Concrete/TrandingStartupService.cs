using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using Smart.BL.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.BL.Services.Concrete
{
    public class TrandingStartupService : ITrandingStartupService
    {
        public IEnumerable<TrandingStartup> GetTrandingStartups()
        {
            return new List<TrandingStartup>() {
                new TrandingStartup {
                    Logo = "startup1.jpg",
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        Photo = "face1.jpg",
                        Country = "USA",
                        Likes = 125
                    },
                    Investor = "Warren Buffet",
                    Founded = 81,
                    Pladged = 34520,
                    Backers = 123,
                    DaysToGo = 12
                },
                new TrandingStartup {
                    Logo = "startup2.jpg",
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        Photo = "face1.jpg",
                        Country = "USA",
                        Likes = 125
                    },
                    Investor = "Warren Buffet",
                    Founded = 78,
                    Pladged = 27800,
                    Backers = 78,
                    DaysToGo = 10
                },
                new TrandingStartup {
                    Logo = "startup3.jpg",
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        Photo = "face1.jpg",
                        Country = "USA",
                        Likes = 125
                    },
                    Investor = "Warren Buffet",
                    Founded = 98,
                    Pladged = 55000,
                    Backers = 157,
                    DaysToGo = 5
                },
                new TrandingStartup {
                    Logo = "startup4.jpg",
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        Photo = "face1.jpg",
                        Country = "USA",
                        Likes = 125
                    },
                    Investor = "Warren Buffet",
                    Founded = 75,
                    Pladged = 25000,
                    Backers = 57,
                    DaysToGo = 17
                }
            };

        }
    }
}
