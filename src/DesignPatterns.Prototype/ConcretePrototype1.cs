using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype;

public class ConcretePrototype1 : IPrototype
{
    public ConcretePrototype1(int paramValue, string paramName)
    {
        value = paramValue;
        valueName = paramName;
    }

    public int value { get; set; }
    public string valueName { get; set; }

    public IPrototype Clone()
    {
       return (IPrototype)this.MemberwiseClone();
    }
}
