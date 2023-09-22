using DesignPatterns.Facade.SubSystem1;
using DesignPatterns.Facade.SubSystem2;
using DesignPatterns.Facade.SubSystem3;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    public class Facade
    {
        public void DoSomeThing()
        {
            Service1 service1 = new Service1();
            Service2 service2 = new Service2();
            Service3 service3 = new Service3();

            service1.Action();
            service2.Action();
            service3.Action();
        }
    }
}
