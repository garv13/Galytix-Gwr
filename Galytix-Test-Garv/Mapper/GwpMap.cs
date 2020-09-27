using CsvHelper.Configuration;
using Galytix_Test_Garv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galytix_Test_Garv.Mapper
{
    public sealed class GwpMap : ClassMap<GwpCountryModel>
    {
        public GwpMap()
        {
            Map(m => m.country).Name("country");
            Map(m => m.variableId).Name("variableId");
            Map(m => m.variableName).Name("variableName");
            Map(m => m.lineOfBusiness).Name("lineOfBusiness");
            Map(m => m.Y2000).Name("Y2000");
            Map(m => m.Y2001).Name("Y2001");
            Map(m => m.Y2002).Name("Y2002");
            Map(m => m.Y2003).Name("Y2003");
            Map(m => m.Y2004).Name("Y2004");
            Map(m => m.Y2005).Name("Y2005");
            Map(m => m.Y2006).Name("Y2006");
            Map(m => m.Y2007).Name("Y2007");
            Map(m => m.Y2008).Name("Y2008");
            Map(m => m.Y2009).Name("Y2009");
            Map(m => m.Y2010).Name("Y2010");
            Map(m => m.Y2011).Name("Y2011");
            Map(m => m.Y2012).Name("Y2012");
            Map(m => m.Y2013).Name("Y2013");
            Map(m => m.Y2014).Name("Y2014");
            Map(m => m.Y2015).Name("Y2015");
        }
    }
}
