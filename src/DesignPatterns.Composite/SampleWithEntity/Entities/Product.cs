using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.SampleWithEntity.Entities;


public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public CategoryItem CategoryItem { get; set; }
    public int CategoryItemId { get; set; }
}
