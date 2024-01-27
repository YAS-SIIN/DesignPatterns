using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Sample;

public class ConcreteClass2 : AbstractClass
{
    protected override void RequiredOperation1()
    {
        Console.WriteLine(" ---> ConcreteClass2.RequiredOperation1() Run....");
    }

    protected override void RequiredOperation2()
    {
        Console.WriteLine(" ---> ConcreteClass2.RequiredOperation2() Run....");
    }

}
