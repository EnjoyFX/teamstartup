using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.BL.Entities;
using Smart.DAL.ContentStorage.Abstract;

namespace Smart.BL.Services.Concrete
{
    public class StartupService : IStartupService
    {
        private readonly IImageRepository _imageRepository;

        private List<StartupEntity> _startups;

        public StartupService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
            InitFakeData();
        }

        public IEnumerable<StartupEntity> GetTopRated()
        {
            return _startups;
        }

        public IEnumerable<StartupEntity> GetTrandingStartups()
        {
            var start = 1;
            var startups = SetStartupUrl(start);
            return startups;
        }

        public IEnumerable<StartupEntity> GetPopularStartups()
        {
            var start = 5;
            var startups = SetStartupUrl(start);
            return startups;
        }

        #region Init Fake Data
        private void InitFakeData()
        {
            string startupCategory = "startups";
            string talentCategory = "talents";

            _startups = new List<StartupEntity>()
            {
                new StartupEntity {
                    Id = 1,
                    LogoUrl = _imageRepository.GetUrl(startupCategory, "startup1.jpg"),
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        PhotoUrl = _imageRepository.GetUrl(talentCategory, "face1.jpg"),
                        Country = "USA",
                        Likes = 125
                    },
                    Investor = "Warren Buffet",
                    InvestedFunds = 81,
                    Pladged = 34520,
                    Backers = 123,
                    DaysToGo = 12,
                    Status = "Pre-seed",
                    Categories = new List<string> { "IoS", ".NET", "Hardware"}
                },
                new StartupEntity {
                    Id = 2,
                    LogoUrl = _imageRepository.GetUrl(startupCategory, "startup2.jpg"),
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        PhotoUrl = _imageRepository.GetUrl(talentCategory, "face1.jpg"),
                        Country = "USA",
                        Likes = 125
                    },
                    Investor = "Warren Buffet",
                    InvestedFunds = 78,
                    Pladged = 27800,
                    Backers = 78,
                    DaysToGo = 10,
                    Status = "Pre-seed",
                    Categories = new List<string> { "IoS", "WEB", "PHP", "Hardware"}
                },
                new StartupEntity {
                    Id = 3,
                    LogoUrl = _imageRepository.GetUrl(startupCategory, "startup3.jpg"),
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        PhotoUrl = _imageRepository.GetUrl(talentCategory, "face1.jpg"),
                        Country = "USA",
                        Likes = 125
                    },
                    Investor = "Warren Buffet",
                    InvestedFunds = 98,
                    Pladged = 55000,
                    Backers = 157,
                    DaysToGo = 5,
                    Status = "Pre-seed",
                    Categories = new List<string> { "Ruby", "WEB"}
                },
                new StartupEntity {
                    Id = 4,
                    LogoUrl = _imageRepository.GetUrl(startupCategory, "startup4.jpg"),
                    Title = "World First $15 64bit PC. Powerful, Small and cheap",
                    Startuper = new Startuper {
                        Name = "Sergey Brin",
                        PhotoUrl = _imageRepository.GetUrl(talentCategory, "face1.jpg"),
                        Country = "USA",
                        Likes = 125
                    },
                    Investor = "Warren Buffet",
                    InvestedFunds = 75,
                    Pladged = 25000,
                    Backers = 57,
                    DaysToGo = 17,
                    Status = "Pre-seed",
                    Categories = new List<string> { "IoS", "PHP", "Python"}
                }
            };
        }

        private IEnumerable<StartupEntity> SetStartupUrl(int start)
        {
            string startupCategory = "startups";
            foreach (var startup in _startups)
            {
                startup.LogoUrl = _imageRepository.GetUrl(startupCategory, string.Format("startup{0}.jpg", start++));
            }
            return _startups;
        }
        #endregion
    }
}
