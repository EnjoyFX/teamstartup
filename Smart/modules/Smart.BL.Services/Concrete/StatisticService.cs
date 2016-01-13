using Smart.BL.Services.Abstract;
using Smart.BL.Entities;
using System.Collections.Generic;
using System;

namespace Smart.BL.Services.Concrete
{
    public class StatisticService : IStatisticService
    {
        public IEnumerable<StatisticEntity> GetStatistic()
        {
            Random rand = new Random();
            List<StatisticEntity> statistic = new List<StatisticEntity>() {
                new StatisticEntity { Text = "Raised online in last 2 years", Value = rand.Next(10000, 50000)},
                new StatisticEntity { Text = "Startups funded over 2 years", Value = rand.Next(20000, 50000)},
                new StatisticEntity { Text = "VC invested in 20 companies utilizing SPVs", Value = rand.Next(30000, 50000)},
                new StatisticEntity { Text = "Active consortiums operating on platform", Value = rand.Next(40000, 50000)},
                new StatisticEntity { Text = "Investors backed consortiums funding", Value = rand.Next(15000, 50000)},
                new StatisticEntity { Text = "Active startup companies last 60 days", Value = rand.Next(25000, 50000)},
                new StatisticEntity { Text = "Talents joined teams last month", Value = rand.Next(35000, 50000)},
                new StatisticEntity { Text = "Companies recruit talents on platform", Value = rand.Next(45000, 50000)},
                new StatisticEntity { Text = "Active candidates over the last 30 days", Value = rand.Next(5000, 50000)},
                new StatisticEntity { Text = "Matches per month", Value = rand.Next(17000, 50000)},

            };

            return statistic;
        }
    }
}
