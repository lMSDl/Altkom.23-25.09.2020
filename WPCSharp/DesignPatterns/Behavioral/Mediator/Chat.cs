using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public class Chat : IChat
    {
        private ICollection<ChatMember> _members = new List<ChatMember>();

        public void Join(ChatMember chatMember)
        {
            _members.Add(chatMember);
        }

        public void Quit(ChatMember chatMember)
        {
            _members.Remove(chatMember);
        }

        public void Send(string from, string to, string message)
        {
            _members.SingleOrDefault(x => x.Nick == to)?.Receive(from, message, true);
        }

        public void Send(string from, string message)
        {
            _members.ToList().ForEach(x => x.Receive(from, message, false));
        }
    }
}
