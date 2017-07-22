using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebpackMVC5App.Helpers
{
    public abstract class WebConfigSettings
    {
        public static string RandomWebConfigValue
        {
            get
            {
                if (ConfigurationManager.AppSettings.AllKeys.Contains("RandomWebConfigValue"))
                {
                    return ConfigurationManager.AppSettings["RandomWebConfigValue"];
                }
                return string.Empty;
            }
        }
    }
}