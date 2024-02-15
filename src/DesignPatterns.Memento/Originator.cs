using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento;

public class Originator
{
    string state;
    public string State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine($"State={state}");
        }
    }

    public Memento CreateMemento()
    {
        Console.WriteLine("Saving state......");
        return (new Memento(state));
    }

    public void SetMemento(Memento memento)
    {
        Console.WriteLine("Restoring state...");
        State = memento.State;
    }
}
