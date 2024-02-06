using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Command.Sample;

public class InvokerEditText
{
    Reciver_EditText editText = new Reciver_EditText();
    List<CommandUndo> commands = new List<CommandUndo>();
    int current = 0;

    public string ExecuteCommand(string input)
    {
        CommandUndo command = new Concreate_AddTextToLable(editText);
        string result = command.Execute(input);

        commands.Add(command);
        current++;

        return result;
    }
     
    public string Undo()
    {
        CommandUndo command = commands[--current];
        return command.UnExecute(command.CurrentInput);
    }

    public string Redo()
    {
        CommandUndo command = commands[current++];
        return command.Execute(command.CurrentInput);
    }
}
