using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Sample;

public class CreateOrder : TakeATaxiHandler
{
    public override ResponseContext Execute(RequestContext requestContext)
    {
        bool orderCreated = true;
        if (orderCreated)
        {
            Console.WriteLine("Order Created.....");
            if (successor != null)
            {
                return successor.Execute(requestContext);
            }
            else
            {
                ///
            }
        }
        return new ResponseContext
        {
            IsSuccess = false,
            Message = "Error Order Created "
        };
    }
}
