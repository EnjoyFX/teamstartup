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

        [HttpGet]
        public ActionResult GetStatistic()
        {
            IStatisticService statisticService = this.ServiceLocator.GetInstance<IStatisticService>();
            return Json(new
            {
                statistic = statisticService.GetStatistic()
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetActionDescription()
        {
            ICallToActionService actionService = this.ServiceLocator.GetInstance<ICallToActionService>();
            return Json(new
            {
                descriptions = actionService.GetDescription()
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetTrandingStartups()
        {
            IStartupService service = this.ServiceLocator.GetInstance<IStartupService>();
            return Json(new
            {
                startups = service.GetTrandingStartups()
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetPopularStartups()
        {
            IStartupService service = this.ServiceLocator.GetInstance<IStartupService>();
            return Json(new
            {
                startups = service.GetPopularStartups()
            }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetTalents()
        {
            ITalentService service = this.ServiceLocator.GetInstance<ITalentService>();
            return Json(new
            {
                talents = service.GetTalents()
            }, JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Helpers

        #endregion

    }
}