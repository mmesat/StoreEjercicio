using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStroe.CommonTools
{
    public class ConfigurationWS
    {
        public static string GetDBStringConection()
        {
            var value = ConfigurationManager.ConnectionStrings["WebStore"];

            if (value == null)
            {
                throw new Exception("Connection to DB is Not set");
            }

            return value.ToString();
        }
    }
}
