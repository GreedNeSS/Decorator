using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class StellarMessageDecorator : MessageDecorator
    {
        public StellarMessageDecorator(IMessage message) : base(message)
        {
        }

        public override void PrintMessage()
        {
            Console.WriteLine("****************");
            message.PrintMessage();
            Console.WriteLine("****************");
        }
    }
}
