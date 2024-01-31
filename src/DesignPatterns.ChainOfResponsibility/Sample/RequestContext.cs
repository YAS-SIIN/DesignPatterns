using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Sample;

public class RequestContext
{
    public int UserId { get; set; }
    public Point Origin { get; set; }
    public Point Destination { get; set; }

}
