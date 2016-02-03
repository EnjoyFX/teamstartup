using Smart.BL.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Smart.BL.Entities;
using Smart.DAL.ContentStorage.Abstract;


namespace Smart.BL.Services.Concrete
{
    public class InvestorService : IInvestorService
    {
        private readonly IImageRepository _imageRepository;

        public InvestorService(IImageRepository imageRepository)
        {
            this._imageRepository = imageRepository;
        }

        public IEnumerable<InvestorEntity> GetNotableInvestors()
        {
            string category = "investors";
            List<InvestorEntity> investors = new List<InvestorEntity>()
            {
                new InvestorEntity() { Id = 1, Name = "Lary Page", ShortQuotation="ShortQuotation1", LargeQuotation="LargeQuotation1", Position="Director1", PhotoUrl=_imageRepository.GetUrl( category, "investor1.jpg")},
                new InvestorEntity() { Id = 2, Name = "Eric Schmidt", ShortQuotation="ShortQuotation2", LargeQuotation="LargeQuotation2", Position="Director2", PhotoUrl=_imageRepository.GetUrl( category, "investor2.jpg") },
                new InvestorEntity() { Id = 3, Name = "Michael Bloomberg", ShortQuotation="ShortQuotation3", LargeQuotation="LargeQuotation3", Position="Director3", PhotoUrl=_imageRepository.GetUrl( category, "investor3.jpg") },
                new InvestorEntity() { Id = 4, Name = "Warren Buffett", ShortQuotation="ShortQuotation4", LargeQuotation="LargeQuotation4", Position="Director4", PhotoUrl=_imageRepository.GetUrl( category, "investor4.jpg") },
                new InvestorEntity() { Id = 4, Name = "Warren Buffett1", ShortQuotation="ShortQuotation5", LargeQuotation="LargeQuotation5", Position="Director5", PhotoUrl=_imageRepository.GetUrl( category, "investor1.jpg") },
                new InvestorEntity() { Id = 5, Name = "Warren Buffett2", ShortQuotation="ShortQuotation6", LargeQuotation="LargeQuotation6", Position="Director6", PhotoUrl=_imageRepository.GetUrl( category, "investor2.jpg") },
                new InvestorEntity() { Id = 4, Name = "Warren Buffett3", ShortQuotation="ShortQuotation7", LargeQuotation="LargeQuotation7", Position="Director7", PhotoUrl=_imageRepository.GetUrl( category, "investor3.jpg") },
            };

            return investors;
        }
    }
}
