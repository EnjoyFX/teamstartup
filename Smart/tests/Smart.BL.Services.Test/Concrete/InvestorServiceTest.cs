using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Smart.BL.Services.Abstract;
using Smart.BL.Services.Concrete;
using Smart.BL.Entities;
using System.Collections.Generic;

namespace Smart.BL.Services.Test.Concrete
{
    [TestClass]
    public class InvestorServiceTest
    {
        private IInvestorService _investorService;

        [TestInitialize]
        public void Initialization()
        {
            this._investorService = new InvestorService();
        }

        [TestMethod]
        public void TestGetNotableInvestors_ReturnType()
        {
            var investors = this._investorService.GetNotableInvestors();
            Assert.IsInstanceOfType(investors, typeof(IEnumerable<InvestorEntity>));
        }
    }
}
