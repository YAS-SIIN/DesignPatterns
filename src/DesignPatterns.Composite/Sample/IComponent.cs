using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.Sample;

public interface IComponent
{
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    double DisplayPrice();
}
