// See https://aka.ms/new-console-template for more information
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.Sample;

Console.WriteLine("Hello, World!");
Target target = new Adapter();
target.Operation();

// Run sample
Console.WriteLine("Run sample");
ISendMessage telegram = new Telegram();
telegram.Send("my test message");

ISendMessage whatsapp = new Whatsapp();
whatsapp.Send("my message");

//GmailService.GmailServiceGoogle gmailServiceGoogle = new GmailService.GmailServiceGoogle();
//gmailServiceGoogle.SendMail("test message");

ISendMessage gmail = new GmailAdapter();
gmail.Send("my test message ");

Console.ReadLine();