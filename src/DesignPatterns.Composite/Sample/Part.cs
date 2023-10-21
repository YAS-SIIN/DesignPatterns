using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Sample;

public class Part : IComponent
{
    public Part(string name, double price)
    {
        this.Price = price;
        this.Name = name;
    }

    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    public double DisplayPrice()
    {
        Console.WriteLine(Name + " : " + Price);
        return Price;
    }
}
