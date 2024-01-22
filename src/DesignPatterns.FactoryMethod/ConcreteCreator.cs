using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod;

public class ConcreteCreator : Creator
{
    public override Product FactoryMethod(ProductCallEnum productCallEnum)
    {
        switch (productCallEnum)
        {
            case ProductCallEnum.ConcreteProduct1:
                return new ConcreteProduct1();

            case ProductCallEnum.ConcreteProduct2:
                return new ConcreteProduct2();

            default:
                return new DefultProduct();
          
        }
    }
}