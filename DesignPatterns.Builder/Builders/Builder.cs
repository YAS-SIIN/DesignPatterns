
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders;

public abstract class Builder
{
    protected Product product;
    public Builder()
    {
        product = new Product();
    }

    public abstract void BuildPart1();
    public abstract void BuildPart2();
    public virtual Product GetResult()
    {
        return product;
    }

}
