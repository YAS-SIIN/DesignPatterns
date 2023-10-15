using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample.MailService;

public static class Implementation
{

    /// <summary>
    /// We can set service in IOC
    /// </summary>
    /// <returns></returns>
    public static IMailServiceImplementor GetImplementor()
    {
        string config;
        //config = ConfigurationManager.AppSettings;
        //config["EmailImplementor"]
        config = "Gmail";

        if (config == "Gmail")
            return new GmailService();
        else if (config == "Yahoo")
            return new YahooService();
        else
            return new MyCompanyMailService();
        
    }
}
