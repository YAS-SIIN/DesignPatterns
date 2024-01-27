using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod.Sample;

public class Client
{
    public static void RunTemplateMethod(AbstractClass abstractClass)
    {
        abstractClass.TemplateMethod();
    }
}
