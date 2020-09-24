using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public class CommandsInvoker
    {
        private static List<ICommand> _executedCommands = new List<ICommand>();

        private ICommand _command;

        public CommandsInvoker(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            if (_command?.Execute() == true)
            {
                _executedCommands.Add(_command);
            }
        }

        public static void Undo()
        {

            var command = _executedCommands.LastOrDefault();
            if (command != null)
            { 
                command.Undo();
                _executedCommands.Remove(command);
            }
        }
    }
}
