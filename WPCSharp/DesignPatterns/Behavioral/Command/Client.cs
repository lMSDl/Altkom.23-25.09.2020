
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Command
{
    public class Client
    {
        public static void Execute()
        {
            var garden = new Garden(5);
            var command1 = new PlantCommand(garden, "drzewo");
            var command2 = new RemoveCommand(garden, "drzewo");
            var command3 = new RemoveCommand(garden, "słonecznik");
            var command4 = new PlantCommand(garden, "słonecznik");

            var plantTreeButton = new CommandsInvoker(command1);
            var removeTreeButton = new CommandsInvoker(command2);
            var removeSunflowerButton = new CommandsInvoker(command3);
            var plantSunflowerButton = new CommandsInvoker(command4);

            Console.WriteLine(garden);

            plantTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantSunflowerButton.Invoke();
            Console.WriteLine(garden);
            removeTreeButton.Invoke();
            Console.WriteLine(garden);
            removeTreeButton.Invoke();
            removeTreeButton.Invoke();
            Console.WriteLine(garden);

            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            //CommandsInvoker.Undo();
            Console.WriteLine(garden);
        }
    }
}
