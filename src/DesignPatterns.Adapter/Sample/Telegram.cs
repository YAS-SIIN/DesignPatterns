using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Sample;

public class Telegram : ISendMessage
{
    public void Send(string Text)
    {
        //
        Console.WriteLine(Text);
        Console.WriteLine($"Send Message With {nameof(Telegram)}  class....");
    }
}
