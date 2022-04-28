using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class ConcreteMessage : Message
    {
        public ConcreteMessage(string message) : base(message)
        {
        }

        public override void PrintMessage()
        {
            Console.WriteLine(_message);
        }
    }
}
