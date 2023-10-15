using DesignPatterns.Decorator.Sample;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator;

public class SendEmailDecorator
{
    private readonly SendEmail _sendEmail;
    public SendEmailDecorator(SendEmail sendEmail)
    {
        _sendEmail = sendEmail;
    }
    public void Send()
    {
        _sendEmail.Send();
    }

    public void SaveLog()
    {
        Console.WriteLine("Log saved");
    }
}
