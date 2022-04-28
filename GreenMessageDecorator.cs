using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class GreenMessageDecorator : MessageDecorator
    {
        public GreenMessageDecorator(IMessage message) : base(message)
        {
        }

        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            message.PrintMessage();
            Console.ResetColor();
        }
    }
}
