using FactoryMethod.Sms.CompanyOneSms;
using FactoryMethod.Sms.CompanyTwoSms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sms.FactoryMethod
{
    public interface ICreatorSample
    {
        ISmsManager FactoryMethodSample();
    }

    public class CreatorSample : ICreatorSample
    {
        public ISmsManager FactoryMethodSample()
        {
            string config = "CompanyOneSms";

            if (config == "CompanyOneSms")
            {
                return new CompanyOneSmsManager();
            }
            else
            {
                return new CompanyTwoSmsManager();
            }
        }
    }
}
