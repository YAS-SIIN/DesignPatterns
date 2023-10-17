

using DesignPatterns.Bridge.Implementors;

namespace DesignPatterns.Bridge.Abstractions;

public abstract class Abstraction
{
    private Implementor _implementor;
    public Abstraction()
    {
        _implementor = new ConcreateImplementor();
    }
    public virtual void Function()
    {
        _implementor.Implementaion();
    }
}


public class RefinedAbstraction : Abstraction
{

}
