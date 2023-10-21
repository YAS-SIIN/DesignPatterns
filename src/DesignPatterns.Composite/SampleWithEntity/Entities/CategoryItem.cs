using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.SampleWithEntity.Entities;

public class CategoryItem : CategoryComponent
{
    public string Link { get; set; }
    public CategoryItem(string name, string link)
    {
        Name = name;
        Link = link;
    }
    public CategoryItem()
    { }

    public override string Print()
    {
        string li = @$"<li> <a href='{Link}'> {Name}  </a> </li>";
        return li;
    }

    public override void Add(CategoryComponent menuComponent)
    {
        throw new NotImplementedException();
    }

    public override void Remove(CategoryComponent menuComponent)
    {
        throw new NotImplementedException();
    }
}
