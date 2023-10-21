 
namespace DesignPatterns.Composite.SampleWithEntity.Entities;

public abstract class CategoryComponent
{
    public int Id { get; set; }
    public string Name { get; set; }

    public virtual string Print()
    {
        throw new NotSupportedException();
    }

    public abstract void Add(CategoryComponent menuComponent);
    public abstract void Remove(CategoryComponent menuComponent);

}


