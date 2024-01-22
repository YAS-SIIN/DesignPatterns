using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod;

public abstract class Creator
{
    public abstract Product FactoryMethod(ProductCallEnum productCallEnum);
}

