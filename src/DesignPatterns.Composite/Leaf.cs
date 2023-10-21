using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Composite;

public class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
    }

    public override void Add(Component component)
    {
        throw new NotImplementedException();
    }

    public override void Display(int Depth)
    {
        Console.WriteLine(new string('-', Depth) + name);
    }

    public override void Remove(Component component)
    {
        throw new NotImplementedException();
    }
}
