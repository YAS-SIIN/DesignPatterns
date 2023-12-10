
using DesignPatterns.Adapter.Sample.ExternalPackages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter.Sample;

public class GmailAdapter : ISendMessage
{
    GmailService gmailService = new GmailService();
    public void Send(string Text)
    {
        gmailService.SendMail(Text);
    }
}
