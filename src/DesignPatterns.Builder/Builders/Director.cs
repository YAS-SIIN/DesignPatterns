using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Builders;

public class Director
{
    private Builder builder;
    public void SetBuilder(Builder builder)
    {
        this.builder = builder;
    }

    public void Construct()
    {
        builder.BuildPart1();
        builder.BuildPart2();
    }
}
