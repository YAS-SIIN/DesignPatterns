using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder;

public class Product
{
    public string Part1 { get; set; }
    public string Part2 { get; set; }
    public string Name { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Product Name:{this.Name}");
        Console.WriteLine($"Product Part1:{this.Part1}");
        Console.WriteLine($"Product Part2:{this.Part2}");
    }
}
