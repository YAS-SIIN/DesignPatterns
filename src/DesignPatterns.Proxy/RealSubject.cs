using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy;

public interface ISubject
{
    void DoAction();
}

public class RealSubject : ISubject
{
    public void DoAction()
    {
        Console.WriteLine("RealSubject.DoAction() is Run....");
    }
}
