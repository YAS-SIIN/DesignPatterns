using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeSample.MailService;

public abstract class MailServiceAbstraction
{
    private readonly IMailServiceImplementor implementor;
    public MailServiceAbstraction()
    {
        implementor = Implementation.GetImplementor();
    }
    public virtual void Send(EmailInformationDto email)
    {
        implementor.SendEmail(email.Reciver, email.Title, email.Message);
    }
}

public class RefinedMailService : MailServiceAbstraction
{

}



public class EmailInformationDto
{
    public string Reciver { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }
}
