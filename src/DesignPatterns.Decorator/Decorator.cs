using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator;

public class Decorator : Component
{
    private readonly Component _component;
    public Decorator(Component component)
    {
        _component = component;
    }
    public override void Operation()
    {
        _component.Operation();
    }

}

