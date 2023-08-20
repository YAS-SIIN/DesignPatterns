using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator;
 
public class ConcreteDecorator : Decorator
{
    public ConcreteDecorator(Component component) : base(component)
    {
    }
    public override void Operation()
    {
        NewOperaton();
        base.Operation();
    }

    public void NewOperaton()
    {
        Console.WriteLine("ConcreteDecorator.NewOperaton");
    }
}


