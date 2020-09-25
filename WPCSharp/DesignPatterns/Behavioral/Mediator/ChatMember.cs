using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public abstract class ChatMember
    {
        private IChat _chat;

        public IChat Chat { get => _chat;
            set
            {
                _chat?.Quit(this);
                _chat = value;
                _chat?.Join(this);
            }
        }

        public string Nick { get; }

        protected ChatMember(string nick)
        {
            Nick = nick;
        }

        public void Send(string message)
        {
            Chat.Send(Nick, message);
        }
        public void Send(string to, string message)
        {
            Chat.Send(Nick, to, message);
        }

        public virtual void Receive(string from, string message, bool isPrivate)
        {
            if (isPrivate)
                Console.WriteLine($"{from} to {Nick}: {message}");
            else
                Console.WriteLine($"{from}: {message}");
        }
    }
}
