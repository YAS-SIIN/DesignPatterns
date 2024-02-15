using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Memento;

public class Caretaker
{
    Memento memento;
    public Memento Memento
    {
        get { return memento; }
        set
        {
            memento = value;
            Console.WriteLine("Caretaker Set Memento...");
        }
    }
}
