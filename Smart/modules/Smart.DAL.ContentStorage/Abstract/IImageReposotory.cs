using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.DAL.ContentStorage.Abstract
{
    public interface IImageRepository
    {
        string GetUrl(string categoryId, string imageId);
    }
}
