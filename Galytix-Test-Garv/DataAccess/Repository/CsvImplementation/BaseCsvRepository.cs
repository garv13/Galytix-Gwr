using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galytix_Test_Garv.DataAccess.Repository.CsvImplementation
{
    public static class BaseCsvRepository
    {
        public static List<Models.GwpCountryModel> gwpDataList
        {
            get
            {
                return _gwpData ?? LoadDateFromCsv();
            }
        }
        private static List<Models.GwpCountryModel> _gwpData;
        private static List<Models.GwpCountryModel> LoadDateFromCsv()
        {
            using (var reader = new StreamReader(@"..\Galytix-Test-Garv\Resources\gwpByCountry.csv", Encoding.Default))
            using (var csv = new CsvReader(reader, System.Globalization.CultureInfo.CurrentCulture))
            {
                csv.Configuration.RegisterClassMap<Mapper.GwpMap>();
                _gwpData = csv.GetRecords<Models.GwpCountryModel>().ToList();
            }
            return _gwpData;
        }
    }
}
