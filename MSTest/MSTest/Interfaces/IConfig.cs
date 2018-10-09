using System;
using MSTest.Configuration;

namespace MSTest.Interfaces
{
    public interface IConfig
    {
        BrowserType? GetBrowser();
        String GetWebsite();
        int GetPageLoadTimeOut();
        int GetElementLoadTimeOut();
    }
}
