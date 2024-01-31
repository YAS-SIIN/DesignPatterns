// See https://aka.ms/new-console-template for more information
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.ChainOfResponsibility.Sample;

Console.WriteLine("Hello, World!");


Handler handler1 = new ConcreteHandler1();
Handler handler2 = new ConcreteHandler2();

handler1.SetSuccessor(handler2);

handler1.HandleRequest(10);
handler1.HandleRequest(1000);



//----------Sample--------------

CheckUserActiveUser checkUserActiveUser = new CheckUserActiveUser();
CreateOrder createOrder = new CreateOrder();
SendOrderToDriver sendOrderToDriver = new SendOrderToDriver();
CheckTest checkTest = new CheckTest();

checkUserActiveUser
    .SetSuccessor(checkTest) //stage 1
    .SetSuccessor(createOrder) //stage 2
    .SetSuccessor(sendOrderToDriver); //stage 3


checkUserActiveUser.Execute(new RequestContext
{
    UserId = 1,
    Origin = new Point { Lat = 53.3636, Lng = 54.22 },
    Destination = new Point { Lat = 53.3636, Lng = 54.22 },
});



Console.ReadLine();