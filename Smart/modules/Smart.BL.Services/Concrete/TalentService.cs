using Smart.BL.Services.Abstract;
using System.Collections.Generic;
using Smart.BL.Entities;
using Smart.DAL.ContentStorage.Abstract;

namespace Smart.BL.Services.Concrete
{
    public class TalentService : ITalentService
    {
        private readonly IImageRepository _imageRepository;

        public TalentService(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        public IEnumerable<Talent> GetTalents()
        {
            string talentCategory = "talents";
            string flagCategory = "flags";

            return new List<Talent> {
                new Talent {
                    Name = "Ronald Brin",
                    PhotoUrl = _imageRepository.GetUrl(talentCategory, "talent1.png"),
                    Country = "USA",
                    FlagUrl = _imageRepository.GetUrl(flagCategory, "usa.jpg"),
                    Title = "Search Arvhitect Guru UX Designer",
                    Rate = 80,
                    PercentSuccess = 95,
                    Jobs = 155,
                    Availability = 24,
                    ResponceTime = 2,
                    Tests = 10,
                    TestsSuccess = 97,
                    Language = "English",
                    LanguageLevel = "Fluent",
                    MemberOfCorporation = "Alphabet Corporation",
                    Categories = new List<string> { "HTML5", "JavaScript", ".NET" },
                    BackTitle = "The best aggregation of angel investors in the world",
                    BackContent = "Smartphones are indispensable and unavoidable in modern day life, but they also have the nasty habit of running out of power when you need them the most! Whether you&#8217;re about to send an important email, or you&#8217;re updating your Facebook status at the end of... "
                },
                 new Talent {
                    Name = "Ronald Brin",
                    PhotoUrl = _imageRepository.GetUrl(talentCategory, "talent1.png"),
                    Country = "USA",
                    FlagUrl = _imageRepository.GetUrl(flagCategory, "usa.jpg"),
                    Title = "Search Arvhitect Guru UX Designer",
                    Rate = 85,
                    PercentSuccess = 85,
                    Jobs = 205,
                    Availability = 12,
                    ResponceTime = 3,
                    Tests = 5,
                    TestsSuccess = 84,
                    Language = "English",
                    LanguageLevel = "Fluent",
                    MemberOfCorporation = "Alphabet Corporation",
                    Categories = new List<string> { "Ruby", "JavaScript", ".NET" },
                    BackTitle = "The best aggregation of angel investors in the world",
                    BackContent = "Smartphones are indispensable and unavoidable in modern day life, but they also have the nasty habit of running out of power when you need them the most! Whether you&#8217;re about to send an important email, or you&#8217;re updating your Facebook status at the end of... "
                },
                  new Talent {
                    Name = "Ronald Brin",
                    PhotoUrl = _imageRepository.GetUrl(talentCategory, "talent1.png"),
                    Country = "USA",
                    FlagUrl = _imageRepository.GetUrl(flagCategory, "usa.jpg"),
                    Title = "Search Arvhitect Guru UX Designer",
                    Rate = 90,
                    PercentSuccess = 91,
                    Jobs = 241,
                    Availability = 24,
                    ResponceTime = 2,
                    Tests = 5,
                    TestsSuccess = 98,
                    Language = "English",
                    LanguageLevel = "Fluent",
                    MemberOfCorporation = "Alphabet Corporation",
                    Categories = new List<string> { "Java", "JavaScript", ".NET" },
                    BackTitle = "The best aggregation of angel investors in the world",
                    BackContent = "Smartphones are indispensable and unavoidable in modern day life, but they also have the nasty habit of running out of power when you need them the most! Whether you&#8217;re about to send an important email, or you&#8217;re updating your Facebook status at the end of... "
                },
                   new Talent {
                    Name = "Ronald Brin",
                    PhotoUrl = _imageRepository.GetUrl(talentCategory, "talent1.png"),
                    Country = "USA",
                    FlagUrl = _imageRepository.GetUrl(flagCategory, "usa.jpg"),
                    Title = "Search Arvhitect Guru UX Designer",
                    Rate = 100,
                    PercentSuccess = 100,
                    Jobs = 278,
                    Availability = 24,
                    ResponceTime = 1,
                    Tests = 10,
                    TestsSuccess = 100,
                    Language = "English",
                    LanguageLevel = "Fluent",
                    MemberOfCorporation = "Alphabet Corporation",
                    Categories = new List<string> { "HTML5", "JavaScript", ".NET" },
                    BackTitle = "The best aggregation of angel investors in the world",
                    BackContent = "Smartphones are indispensable and unavoidable in modern day life, but they also have the nasty habit of running out of power when you need them the most! Whether you&#8217;re about to send an important email, or you&#8217;re updating your Facebook status at the end of... "
                }
            };
        }
    }
}
