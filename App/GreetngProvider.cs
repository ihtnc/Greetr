using Greetr.Lib;

namespace Greetr.App;

public class GreetngProvider : IGreetngProvider
{
    public IGreetng GetGreetng() => new Greetng();
}