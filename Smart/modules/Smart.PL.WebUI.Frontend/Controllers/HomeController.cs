using Microsoft.Practices.ServiceLocation;
using Smart.BL.Entities;
using Smart.BL.Services.Abstract;
using Smart.PL.WebUI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Smart.PL.WebUI.Frontend.Controllers
{
    public class HomeController : BaseController
    {

        #region Fields

        #endregion

        #region Constructors

        public HomeController(IServiceLocator serviceLocator): base(serviceLocator)
        {
        }

        #endregion

        #region Web Actions

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetStartupMarkets()
        {
            IStartupMarketService marketService = this.ServiceLocator.GetInstance<IStartupMarketService>();
            return Json(new
            {
                startupMarkets = marketService.GetMostPopular()
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetMostPopularJobMarkets()
        {
            IJobMarketService marketService = this.ServiceLocator.GetInstance<IJobMarketService>();
            return Json(new
            {
                jobMarkets = marketService.GetMostPopular()
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetNotableInvestors()
        {
            IInvestorService investorService = this.ServiceLocator.GetInstance<IInvestorService>();
            return Json(new
            {
                notableInvestors = investorService.GetNotableInvestors()
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetTopRatedStartups()
        {
            IStartupService startupService = this.ServiceLocator.GetInstance<IStartupService>();
            return Json(new
            {
                topRatedStartups = startupService.GetTopRated()
            }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Helpers

        #endregion

    }
}