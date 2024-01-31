using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Sample;

public class SendOrderToDriver : TakeATaxiHandler
{
    public override ResponseContext Execute(RequestContext requestContext)
    {
        Console.WriteLine("Send tto Driver");
        if (successor != null)
        {
            return successor.Execute(requestContext);
        }

        return new ResponseContext
        {
            IsSuccess = true,
            Message = "Order Create and send to driver"
        };

    }
}
