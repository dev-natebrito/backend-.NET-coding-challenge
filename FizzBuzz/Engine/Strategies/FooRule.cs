namespace FizzBuzz.Engine.Strategies;

public class FooRule : IFizzBuzzRule
{
    public bool IsMatch(int number) => number * 10 > 100;
    public string Output => "Foo";
}