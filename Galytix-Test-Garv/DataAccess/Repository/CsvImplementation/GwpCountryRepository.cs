using Galytix_Test_Garv.DataAccess.Repository.Interfaces;
using Galytix_Test_Garv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galytix_Test_Garv.DataAccess.Repository.CsvImplementation
{
    public class GwpCountryRepository : IGwpCountryRepository
    {
        public IEnumerable<GwpCountryModel> GetGwpsByCountryCode(string countryCode)
        {
            var data = BaseCsvRepository.gwpDataList;
            if (data != null)
            {
                return data.Where(x => x.country == countryCode);
            }
            return null;
        }
    }
}
