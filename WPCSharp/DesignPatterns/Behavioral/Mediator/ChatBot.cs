﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCSharp.DesignPatterns.Behavioral.Mediator
{
    public class ChatBot : ChatMember
    {
        public ChatBot(string nick) : base(nick)
        {
        }

        public override void Receive(string from, string message, bool isPrivate)
        {
            if(isPrivate)
            {
                Chat.Send(Nick, from, message);
            }
            else
            {
                if(from != Nick)
                    Chat.Send(Nick, message);
            }
        }
    }
}
