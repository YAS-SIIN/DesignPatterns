// See https://aka.ms/new-console-template for more information
using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Sample;

Console.WriteLine("Hello, World!");


Context context;

//Injection
context = new Context(new ConcreteStrategyA());
context.ContextInterface();

//Injection
context = new Context(new ConcreteStrategyB());
context.ContextInterface();

//Injection
context = new Context(new ConcreteStrategyC());
context.ContextInterface();


//----------------Sample------------
Console.WriteLine("----------------Sample------------");

var users = new User[]
          {
              new User { Id = 101 ,Credit=5000,Name="Ehsan" ,LastName="Babaei"},
              new User {Id = 105 ,Credit=8000,Name="Roshan" ,LastName="Ahmadi"},
              new User {Id = 109,Credit=3000, Name="Ali" ,LastName="Ahmadi"},
          };

Console.WriteLine("----------------Befor Sort------------");
foreach (var item in users)
{
    item.DisplayUser();
}

Array.Sort(users, new UserByCredit_Comparer());
Console.WriteLine("----------------After Sort------------");
foreach (var item in users)
{
    item.DisplayUser();
}



Array.Sort(users, new UserById_Comparer());
Console.WriteLine("----------------After Sort By Id------------");
foreach (var item in users)
{
    item.DisplayUser();
}
Console.ReadLine();