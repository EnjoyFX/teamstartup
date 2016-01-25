using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Smart.BL.Services.Abstract;
using Smart.BL.Services.Concrete;
using System.Collections.Generic;
using Smart.BL.Entities;
using Smart.DAL.ContentStorage.Abstract;
using Moq;

namespace Smart.BL.Services.Test.Concrete
{
    [TestClass]
    public class StartupMarketServiceTest
    {
        private IStartupMarketService _startupMarketService;

        [TestInitialize]
        public void Initialization()
        {
            var imageRepositoryMock = new Mock<IImageRepository>();
            this._startupMarketService = new StartupMarketService(imageRepositoryMock.Object);
        }

        [TestMethod]
        public void GetMostPopular_ReturnType()
        {
            var markets = this._startupMarketService.GetMostPopular();
            Assert.IsInstanceOfType(markets, typeof(IEnumerable<StartupMarketEntity>));
        }
    }
}
