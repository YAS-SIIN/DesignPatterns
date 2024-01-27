using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod;

public class ConcreteClass : AbstractClass
{
    protected override void PrimitiveOperation1()
    {
        Console.WriteLine("ConcreteClass.PrimitiveOperation1()");

    }

    protected override void PrimitiveOperation2()
    {
        Console.WriteLine("ConcreteClass.PrimitiveOperation2()");
    }
}
