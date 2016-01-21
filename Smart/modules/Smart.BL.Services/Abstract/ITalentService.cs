using Smart.BL.Entities;
using System.Collections.Generic;

namespace Smart.BL.Services.Abstract
{
    public interface ITalentService
    {
        IEnumerable<Talent> GetTalents();
    }
}
