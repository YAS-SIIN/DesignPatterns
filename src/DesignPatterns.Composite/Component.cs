using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite;

public abstract class Component
{
    protected string name;
    public Component(string name)
    {
        this.name = name;
    }
    public abstract void Add(Component component);
    public abstract void Remove(Component component);
    public abstract void Display(int Depth);
}
