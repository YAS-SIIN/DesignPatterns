using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility;

public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 50)
        {
            Console.WriteLine($"ConcreteHandler2 {request}....");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}
