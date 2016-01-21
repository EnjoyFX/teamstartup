using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.BL.Entities;

namespace Smart.BL.Services.Concrete
{
    public class PopularStartupService : IPopularStartupService
    {
        public IEnumerable<PopularStartup> GetPopularStartups()
        {
            return new List<PopularStartup> {
                new PopularStartup {
                    Logo = "startup5.jpg",
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        Photo = "face1.jpg",
                        Country = "USA",
                        Likes = 125
                    },
                    Status = "Pre-seed",
                    Categories = new List<string> { "IoS", ".NET", "Hardware"}
                },
                new PopularStartup {
                    Logo = "startup6.jpg",
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        Photo = "face1.jpg",
                        Country = "USA",
                        Likes = 125
                    },
                    Status = "Pre-seed",
                    Categories = new List<string> { "IoS", "WEB", "PHP", "Hardware"}
                },
                new PopularStartup {
                    Logo = "startup7.jpg",
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        Photo = "face1.jpg",
                        Country = "USA",
                        Likes = 125
                    },
                    Status = "Pre-seed",
                    Categories = new List<string> { "Ruby", "WEB"}
                },
                new PopularStartup {
                    Logo = "startup8.jpg",
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        Photo = "face1.jpg",
                        Country = "USA",
                        Likes = 125
                    },
                    Status = "Pre-seed",
                    Categories = new List<string> { "IoS", "PHP", "Python"}
                }
            };
        }
    }
}
