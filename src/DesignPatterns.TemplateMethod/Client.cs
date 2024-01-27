using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod;

public class Client
{

    public static void Run(AbstractClass abstractClass)
    {
        abstractClass.TemplateMethod();
    }
}
