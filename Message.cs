using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class Message : IMessage
    {
        protected string _message;

        public Message(string message)
        {
            _message = message;
        }

        public abstract void PrintMessage();
    }
}
