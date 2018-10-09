﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSTest.Interfaces;
using System.Configuration;
using MSTest.ObjectRepository;

namespace MSTest.Configuration
{
   public class AppConfigReader: IConfig
    {

        public BrowserType? GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            try
            {
                return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int GetElementLoadTimeOut()
        {
            string timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.ElementLoadTimeout);
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }

        public int GetPageLoadTimeOut()
        {
            string timeout = ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeout);
            if (timeout == null)
                return 30;
            return Convert.ToInt32(timeout);
        }
        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
    }
}
