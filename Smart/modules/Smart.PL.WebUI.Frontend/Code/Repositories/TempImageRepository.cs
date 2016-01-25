using Smart.DAL.ContentStorage.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Smart.PL.WebUI.Frontend.Code.Repositories
{
    public class TempImageRepository : IImageRepository
    {
        public string GetUrl(string categoryId, string imageId)
        {
            string imageBaseUrl = VirtualPathUtility.ToAbsolute("~/DataContent/images");            
            return string.Format("{0}/{1}/{2}", imageBaseUrl, categoryId, imageId);            
        }
    }
}