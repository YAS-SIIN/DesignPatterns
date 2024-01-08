using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype;

public class ConcretePrototype2 : IPrototype
{
    public ConcretePrototype1 myApplicationService { get; set; }


    public ConcretePrototype2(ConcretePrototype1 myApplicationService)
    {
        this.myApplicationService = myApplicationService;
    }
    public IPrototype Clone()
    {
        var result = (ConcretePrototype2)this.MemberwiseClone();
        result.myApplicationService = (ConcretePrototype1)this.myApplicationService.Clone();
        return (IPrototype)result;
    }
}
