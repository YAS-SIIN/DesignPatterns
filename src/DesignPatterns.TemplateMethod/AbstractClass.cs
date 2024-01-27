using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod;

public abstract class AbstractClass
{

    public void TemplateMethod()
    {
        Console.WriteLine("==========>>AbstractClass.TemplateMethod()  Start");
        PrimitiveOperation1();
        PrimitiveOperation2();
        Console.WriteLine("---------->>AbstractClass.TemplateMethod()  End");
    }

    protected abstract void PrimitiveOperation1();
    protected abstract void PrimitiveOperation2();
}