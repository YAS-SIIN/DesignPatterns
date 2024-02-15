using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento;

public class Memento
{
    string state;
    public Memento(string state)
    {
        this.state = state;
    }

    public string State
    {
        get { return state; }
    }
}
