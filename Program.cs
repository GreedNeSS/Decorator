using Decorator;

Console.WriteLine("***** Decorator *****");

string text = "Hello GreedNeSS!";
Message message = new ConcreteMessage(text);

List<IMessage> messages = new List<IMessage>
{
    message,
    new GreenMessageDecorator(message),
    new RedMessageDecorator(message),
    new StellarMessageDecorator(message),
    new GreenMessageDecorator(new StellarMessageDecorator(message)),
    new RedMessageDecorator(new StellarMessageDecorator(message)),
};

messages.ForEach(m => m.PrintMessage());