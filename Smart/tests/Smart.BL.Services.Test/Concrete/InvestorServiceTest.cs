using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Smart.BL.Services.Abstract;
using Smart.BL.Services.Concrete;
using Smart.BL.Entities;
using System.Collections.Generic;
using Smart.DAL.ContentStorage.Abstract;
using Moq;

namespace Smart.BL.Services.Test.Concrete
{
    [TestClass]
    public class InvestorServiceTest
    {
        private IInvestorService _investorService;

        [TestInitialize]
        public void Initialization()
        {
            var imageRepositoryMock = new Mock<IImageRepository>();
            this._investorService = new InvestorService(imageRepositoryMock.Object);
        }

        [TestMethod]
        public void TestGetNotableInvestors_ReturnType()
        {
            var investors = this._investorService.GetNotableInvestors();
            Assert.IsInstanceOfType(investors, typeof(IEnumerable<InvestorEntity>));
        }
    }
}
