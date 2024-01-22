using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Sample;

public class UserById_Comparer : IComparer<User>
{
    public int Compare(User x, User y)
    {
        if (x.Id == y.Id)
            return 0;
        else if (x.Id > y.Id)
            return 1;
        else
            return -1;
    }
}
