using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Smart.PL.WebUI.Controllers
{
    public abstract class BaseController: Controller
    {
        #region Fields

        private readonly IServiceLocator _serviceLocator;

        #endregion

        #region Constructors

        public BaseController(IServiceLocator serviceLocator)
        {
            this._serviceLocator = serviceLocator;
        }

        #endregion

        #region Protected Properites

        protected IServiceLocator ServiceLocator
        {
            get
            {
                return this._serviceLocator;
            }
        }

        #endregion
    }
}
