using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Sample;

public abstract class AbstractClass
{
    public void TemplateMethod()
    {
        this.Hook1();
        this.BaseOperation1();
        this.RequiredOperation1();
        this.BaseOperation2();
        this.RequiredOperation2();
        this.Hook2();
    }


    protected void BaseOperation1()
    {
        Console.WriteLine("AbstractClass.BaseOperation1() Run....");
    }
    protected void BaseOperation2()
    {
        Console.WriteLine("AbstractClass.BaseOperation2() Run....");
    }

    //این متد نیاز به توسعه توسط زر کلاس دارد
    protected abstract void RequiredOperation1();
    protected abstract void RequiredOperation2();

    protected virtual void Hook1() { }
    protected virtual void Hook2() { }
}