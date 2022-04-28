using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class RedMessageDecorator : MessageDecorator
    {
        public RedMessageDecorator(IMessage message) : base(message)
        {
        }

        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            message.PrintMessage();
            Console.ResetColor();
        }
    }
}
