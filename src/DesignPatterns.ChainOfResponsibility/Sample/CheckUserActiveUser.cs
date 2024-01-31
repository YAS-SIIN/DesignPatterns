using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Sample;

public class CheckUserActiveUser : TakeATaxiHandler
{
    public override ResponseContext Execute(RequestContext requestContext)
    {
        if (requestContext.UserId != 1)
        {
            Console.WriteLine("User Not Active");
            return new ResponseContext
            {
                IsSuccess = false,
                Message = "User not Active"
            };
        }
        else if (successor != null)
        {
            Console.WriteLine("User Is Active");
            return successor.Execute(requestContext);
        }
        else
        {
            return new ResponseContext
            {
                IsSuccess = false,
                Message = "error"
            };
        }
    }
}
