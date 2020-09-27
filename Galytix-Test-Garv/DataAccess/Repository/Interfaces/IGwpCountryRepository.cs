using Galytix_Test_Garv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galytix_Test_Garv.DataAccess.Repository.Interfaces
{
    public interface IGwpCountryRepository
    {
        IEnumerable<GwpCountryModel> GetGwpsByCountryCode(string countryCode);
    }
}
