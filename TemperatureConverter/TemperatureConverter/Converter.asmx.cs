using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TemperatureConverter
{
    /// <summary>
    /// Summary description for Converter
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Converter : System.Web.Services.WebService
    {

        [WebMethod()]
        public Double fToc(double f)
        {
            return (f - 32) * 5 / 9;
        }

        [WebMethod()]
        public Double fTok(double f)
        {
            return ((f - 32) * 5 / 9) + 273.15;
        }

        [WebMethod()]
        public Double cTof(double c)
        {
            return (c * 9 / 5) + 32;
        }

        [WebMethod()]
        public Double cTok(double c)
        {
            return (c + 273.15);
        }

        [WebMethod()]
        public Double kTof(double k)
        {
            return ((k - 273.15) * 9 / 5) + 32;
        }

        [WebMethod()]
        public Double kToc(double k)
        {
            return (k - 273.15);
        }
    }
}
