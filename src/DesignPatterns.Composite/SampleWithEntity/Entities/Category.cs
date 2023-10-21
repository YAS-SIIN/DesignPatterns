using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.SampleWithEntity.Entities;

public class Category : CategoryComponent
{
    readonly List<CategoryComponent> _menuComponents = new List<CategoryComponent>();
    public ICollection<CategoryComponent> MenuItems => _menuComponents;
    public Category(string name)
    {
        Name = name;
    }
    public Category()
    { }

    public override void Add(CategoryComponent menuComponent)
    {
        _menuComponents.Add(menuComponent);
    }

    public override void Remove(CategoryComponent menuComponent)
    {
        _menuComponents.Remove(menuComponent);
    }

    public override string Print()
    {
        string ul = @$"<ul> {Name}";
        foreach (var menuComponent in _menuComponents)
        {
            ul += menuComponent.Print();
        }
        ul += @$"</ul> ";
        return ul;
    }
}
