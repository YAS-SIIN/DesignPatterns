using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy.Sample;

public  class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Credit { get; set; }


    public void DisplayUser()
    {
        Console.WriteLine($"Id; {Id} Name: {Name}  LastName: {LastName} Credit:{Credit}");
    }

}
