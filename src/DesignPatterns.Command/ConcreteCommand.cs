using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command;

public class ConcreteCommand : Command
{
    public ConcreteCommand(Reciver reciver) : base(reciver)
    {

    }
    public override void Execute()
    {
        reciver.Action();
    }
}
