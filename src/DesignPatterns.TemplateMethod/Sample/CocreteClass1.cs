using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Sample;

public class CocreteClass1 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine(" ---> CocreteClass1.RequiredOperation1() Run....");
    }

    protected override void RequiredOperation2()
    {
        Console.WriteLine(" ---> CocreteClass1.RequiredOperation2() Run....");
    }

    protected override void Hook1()
    {
        Console.WriteLine(" ---> CocreteClass1.Hook1() Run....");
        base.Hook1();
    }
}
