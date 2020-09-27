using Galytix_Test_Garv.DataAccess.Repository.Interfaces;
using Galytix_Test_Garv.DTO.CountryGwp;
using Galytix_Test_Garv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galytix_Test_Garv.Service
{
    public class CountryGwpService : ICountryGwpService
    {
        public CountryGwpService(IGwpCountryRepository gwpCountryRepository)
        {
            _gwpCountryRepository = gwpCountryRepository;
        }

        private IGwpCountryRepository _gwpCountryRepository { get; set; }
        public List<AvgPostResponseDto> GetAvgGwp(string countryCode, List<string> lob)
        {
            var data = _gwpCountryRepository.GetGwpsByCountryCode(countryCode);
            if (data == null)
                return null;

            List<AvgPostResponseDto> avgList = new List<AvgPostResponseDto>();
            foreach(string lobName in lob)
            {
                var gwpCountry = data.Where(_ => _.lineOfBusiness.ToLower() == lobName.Trim().ToLower()).FirstOrDefault();
                if(gwpCountry != null)                
                    avgList.Add(new AvgPostResponseDto
                    {
                        Lob = gwpCountry.lineOfBusiness,
                        Gwp = GetAverageGwp(gwpCountry)
                    });                
            }
            return avgList;
        }
        private double GetAverageGwp(GwpCountryModel gwp)
        {
            double total = 0;
            double parseResult;
            total += double.TryParse(gwp.Y2008, out parseResult) ? parseResult : 0;
            total += double.TryParse(gwp.Y2009, out parseResult) ? parseResult : 0;
            total += double.TryParse(gwp.Y2010, out parseResult) ? parseResult : 0;
            total += double.TryParse(gwp.Y2011, out parseResult) ? parseResult : 0;
            total += double.TryParse(gwp.Y2012, out parseResult) ? parseResult : 0;
            total += double.TryParse(gwp.Y2013, out parseResult) ? parseResult : 0;
            total += double.TryParse(gwp.Y2014, out parseResult) ? parseResult : 0;
            total += double.TryParse(gwp.Y2015, out parseResult) ? parseResult : 0;

            return total / 8;
        }
    }
}
