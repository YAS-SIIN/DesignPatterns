using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Sample;

public abstract class TakeATaxiHandler : IHandler
{

    protected IHandler successor;

    public abstract ResponseContext Execute(RequestContext requestContext);

    public IHandler SetSuccessor(IHandler handler)
    {
        this.successor = handler;
        return successor;
    }
}