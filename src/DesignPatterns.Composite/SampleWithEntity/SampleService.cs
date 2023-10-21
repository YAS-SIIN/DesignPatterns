using DesignPatterns.Composite.SampleWithEntity.Contexts;
using DesignPatterns.Composite.SampleWithEntity.Entities;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite.SampleWithEntity;

public class SampleService
{ 
    private readonly DBContext _context;
    public SampleService()
    {
        _context = new DBContext(); 
    }

    public void GetResult()
    {
        var menus = _context.CategoryComponents.ToList();
        string result = "";
        foreach (var item in menus.Where(p => p.GetType() == typeof(CategoryItem)))
        {
            _context.Products.Add(new Product
            {
                Name = "test",
                CategoryItem = item as CategoryItem,
            });
            _context.SaveChanges();

            result += item.Print();
        }
        Console.WriteLine(result);

    }

    public Category InitializeData()
    {
        var Products = new Category("Product");
        var testItem = new CategoryItem("Mobile", "/Mobile");
        Products.Add(testItem);
        Products.Add(new CategoryItem("Laptop", "/Laptop"));
        Products.Add(new CategoryItem("Hedphone", "/Hedphone"));
        Products.Add(new CategoryItem("Book", "/Book"));

        _context.CategoryComponents.Add(Products);
        _context.SaveChanges();
        return Products;
    }
}
