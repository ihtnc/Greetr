// See https://aka.ms/new-console-template for more information
var provider = new Greetr.App.GreetngProvider();
var greetng = provider.GetGreetng();
var message = greetng.Get();

Console.WriteLine(message);
