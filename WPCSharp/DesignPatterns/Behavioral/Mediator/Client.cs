
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public class Client
    {
        public static void Execute()
        {

            ChatMember user1 = new ChatUser("User1");
            ChatMember bot = new ChatBot("Bot");

            Chat chat = new Chat();
            user1.Chat = chat;
            bot.Chat = chat;

            string @string;
            do
            {
                @string = Console.ReadLine();
                var split = @string.Split(':');
                if (split.Length == 2)
                    user1.Send(split[0], split[1]);
                else
                    user1.Send(@string);

            } while (@string != "quit");
        }
    }
}
