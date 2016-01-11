using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Smart.BL.Services.Abstract;
using Smart.BL.Services.Concrete;
using System.Collections.Generic;
using Smart.BL.Entities;

namespace Smart.BL.Services.Test.Concrete
{
    [TestClass]
    public class StartupServiceTest
    {
        private IStartupService _startupService;

        [TestInitialize]
        public void Initialization()
        {
            this._startupService = new StartupService();
        }

        [TestMethod]
        public void GetTopRated_ReturnType()
        {
            var startups = this._startupService.GetTopRated();
            Assert.IsInstanceOfType(startups, typeof(IEnumerable<StartupEntity>));
        }
    }
}
