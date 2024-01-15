using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sms.CompanyOneSms;

public class CompanyOneSmsManager : ISmsManager
{
    public List<SmsDto> GetList()
    {
        List<SmsDto> sms = new List<SmsDto>();
        return sms;
    }

    public void Send(SmsDto sms)
    {
        Console.WriteLine("Send Sms  With CompanyOneManager..........");
        //send sms
    }
}
