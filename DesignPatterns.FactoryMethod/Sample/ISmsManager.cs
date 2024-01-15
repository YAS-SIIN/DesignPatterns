using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Sms
{
    public interface ISmsManager
    {
        void Send(SmsDto sms);
        List<SmsDto> GetList();
    }

    public class SmsDto
    {
        public string Reciver { get; set; }
        public string Sender { get; set; }
        public string Message { get; set; }
    }
}
