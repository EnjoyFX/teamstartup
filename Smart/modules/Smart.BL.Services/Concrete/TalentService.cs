using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.BL.Entities;

namespace Smart.BL.Services.Concrete
{
    public class TalentService : ITalentService
    {
        public IEnumerable<Talent> GetTalents()
        {
            return new List<Talent> {
                new Talent {
                    Name = "Ronald Brin",
                    Photo = "talent1.png",
                    Country = "USA",
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
                    Categories = new List<string> { "HTML5", "JavaScript", ".NET" }
                },
                 new Talent {
                    Name = "Ronald Brin",
                    Photo = "talent1.png",
                    Country = "USA",
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
                    Categories = new List<string> { "Ruby", "JavaScript", ".NET" }
                },
                  new Talent {
                    Name = "Ronald Brin",
                    Photo = "talent1.png",
                    Country = "USA",
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
                    Categories = new List<string> { "Java", "JavaScript", ".NET" }
                },
                   new Talent {
                    Name = "Ronald Brin",
                    Photo = "talent1.png",
                    Country = "USA",
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
                    Categories = new List<string> { "HTML5", "JavaScript", ".NET" }
                }
            };
        }
    }
}
