using Smart.BL.Entities;
using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.DAL.ContentStorage.Abstract;

namespace Smart.BL.Services.Concrete
{
    public class StartupMarketService : IStartupMarketService
    {
        #region Fields

        private readonly IImageRepository _imageRepository;

        #endregion

        #region Constructors

        public StartupMarketService(IImageRepository imageRepository)
        {
            this._imageRepository = imageRepository;
        }

        #endregion

        #region IMarketService

        public IEnumerable<StartupMarketEntity> GetMostPopular()
        {
            string imageCategoryId = "startup-markets";

            List<StartupMarketEntity> markets = new List<StartupMarketEntity>()
            {
                new StartupMarketEntity() { Id = 1, Name = "Software", IconUrl = this._imageRepository.GetUrl(imageCategoryId, "software.png") },
                new StartupMarketEntity() { Id = 2, Name = "Consumer Internet", IconUrl = this._imageRepository.GetUrl(imageCategoryId, "consumer_internet.png") },
                new StartupMarketEntity() { Id = 3, Name = "E-Commerce", IconUrl = this._imageRepository.GetUrl(imageCategoryId, "E_comerse.png") },
                new StartupMarketEntity() { Id = 4, Name = "Financial Service", IconUrl = this._imageRepository.GetUrl(imageCategoryId, "fin_serv.png") },
                new StartupMarketEntity() { Id = 5, Name = "Hardware", IconUrl = this._imageRepository.GetUrl(imageCategoryId, "Hardware.png") },
                new StartupMarketEntity() { Id = 6, Name = "Healthcare", IconUrl = this._imageRepository.GetUrl(imageCategoryId, "helthcare.png") },
                new StartupMarketEntity() { Id = 7, Name = "Entertainment", IconUrl = this._imageRepository.GetUrl(imageCategoryId, "entertaim.png") },
                new StartupMarketEntity() { Id = 8, Name = "Education", IconUrl = this._imageRepository.GetUrl(imageCategoryId, "education.png") }

            };

            return markets;
        }

        #endregion
    }
}