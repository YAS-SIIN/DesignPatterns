using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Sample;

public class Reciver_EditText
{
    private string _value;

    public string Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public string AddText(string input)
    {
        _value +=input;
        return _value;
    }

    public string RemoveText(string input)
    {
        _value = _value.Substring(0, _value.Length - input.Length);
        return _value;
    }
}
