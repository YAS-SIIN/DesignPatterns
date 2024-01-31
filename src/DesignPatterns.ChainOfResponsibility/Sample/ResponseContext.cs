using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility.Sample;

public class ResponseContext
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}