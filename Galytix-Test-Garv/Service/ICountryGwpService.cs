using Galytix_Test_Garv.DTO.CountryGwp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galytix_Test_Garv.Service
{
    public interface ICountryGwpService
    {
        List<AvgPostResponseDto> GetAvgGwp(string countryCode, List<string> lob);
    }
}
