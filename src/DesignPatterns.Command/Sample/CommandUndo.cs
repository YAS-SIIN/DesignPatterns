using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Sample;

public abstract class CommandUndo
{
    protected Reciver_EditText reciver_EditText;
    public CommandUndo(Reciver_EditText reciver_EditText)
    {
        this.reciver_EditText = reciver_EditText;
    }

    public string CurrentInput { get; set; }


    public abstract string Execute(string input);
    public abstract string UnExecute(string input);
}
