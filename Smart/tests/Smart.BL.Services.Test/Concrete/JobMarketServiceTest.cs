using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Smart.BL.Services.Abstract;
using Smart.BL.Services.Concrete;
using Smart.BL.Entities;
using System.Collections.Generic;

namespace Smart.BL.Services.Test.Concrete
{
    [TestClass]
    public class JobMarketServiceTest
    {
        private IJobMarketService _jobMarketService;

        [TestInitialize]
        public void Initialization()
        {
            this._jobMarketService = new JobMarketService();
        }

        [TestMethod]
        public void GetMostPopular_ReturnType()
        {
            var markets = this._jobMarketService.GetMostPopular();
            Assert.IsInstanceOfType(markets, typeof(IEnumerable<JobMarketEntity>));
        }
    }
}
