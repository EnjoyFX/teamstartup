﻿using Smart.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart.BL.Services.Abstract
{
    public interface IJobMarketService
    {
        IEnumerable<JobMarketEntity> GetMostPopular();
    }
}
