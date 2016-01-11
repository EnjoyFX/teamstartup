using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Smart.BL.Services.Abstract;
using Smart.BL.Services.Concrete;
using System.Collections.Generic;
using Smart.BL.Entities;

namespace Smart.BL.Services.Test.Concrete
{
    [TestClass]
    public class StartupMarketServiceTest
    {
        private IStartupMarketService _startupMarketService;

        [TestInitialize]
        public void Initialization()
        {
            this._startupMarketService = new StartupMarketService();
        }

        [TestMethod]
        public void GetMostPopular_ReturnType()
        {
            var markets = this._startupMarketService.GetMostPopular();
            Assert.IsInstanceOfType(markets, typeof(IEnumerable<StartupMarketEntity>));
        }
    }
}
