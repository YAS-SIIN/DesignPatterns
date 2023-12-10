using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Sample.ExternalPackages;

public class GmailService
{
    public void SendMail(string text)
    {
        Console.WriteLine($"Gmail service message : {text}");
    }
}
