using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample.MailService;

public interface IMailServiceImplementor
{
    void SendEmail(string Reciver, string Title, string Message);
}

public class GmailService : IMailServiceImplementor
{
    public void SendEmail(string Reciver, string Title, string Message)
    {
        //Send email
        Console.WriteLine($"Email --{Title}-- Sended to --{Reciver}--  With   **{nameof(GmailService)}**");
    }
}

public class YahooService : IMailServiceImplementor
{
    public void SendEmail(string Reciver, string Title, string Message)
    {
        //Send email
        Console.WriteLine($"Email --{Title}-- Sended to --{Reciver}-- With    **{nameof(YahooService)}**");
    }
}


public class MyCompanyMailService : IMailServiceImplementor
{
    public void SendEmail(string Reciver, string Title, string Message)
    {

        Console.WriteLine($"Email --{Title}-- Sended to --{Reciver}-- With    **{nameof(MyCompanyMailService)}**");
    }

}

