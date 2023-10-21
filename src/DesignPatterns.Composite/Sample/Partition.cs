using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Sample;

public class Partition : IComponent
{
    private readonly List<IComponent> _component = new List<IComponent>();
    public Partition()
    {

    }
    public Partition(string name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    public string Name { get ; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    public double DisplayPrice()
    {
        double sumPrice = Price;

        foreach (var item in _component)
        {
            sumPrice += item.DisplayPrice();
        }
        Console.WriteLine(Name + " : " + sumPrice);
        return sumPrice;
    }

    public void Add(IComponent composite)
    {
        _component.Add(composite);
    }

    public void Remove(IComponent composite)
    {
        _component.Remove(composite);
    }


}