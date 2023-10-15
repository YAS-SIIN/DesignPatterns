

using DesignPatterns.Bridge.Implementors;

namespace DesignPatterns.Bridge.Abstractions;

public abstract class Abstraction
{
    private Implementor implementor;
    public Abstraction()
    {
        implementor = new ConcreateImplementor();
    }
    public virtual void Function()
    {
        implementor.Implementaion();
    }
}


public class RefinedAbstraction : Abstraction
{

}
