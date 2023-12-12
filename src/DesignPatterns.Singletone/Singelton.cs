using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singletone;

public sealed class Singelton
{
    public static Singelton uniqeSingelton;
    private Singelton() {
    
    }

    public static Singelton GetInstance()
    {
        if (uniqeSingelton is null)
            uniqeSingelton = new();
        
        return uniqeSingelton;
    }
}
