using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod;

public class ConcreteProduct1 : Product
{
    public override void Excute()
    {
        Console.WriteLine("ConcreteProduct1.Excute...");
    }
}
