using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter;

public class Adapter : Target
{
    private Adaptee adaptee;
    public Adapter()
    {
        adaptee = new Adaptee();
    }
    public override void Operation()
    {
        adaptee.SpecificOperation();
    }
}
