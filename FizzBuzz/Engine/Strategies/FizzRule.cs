namespace FizzBuzz.Engine.Strategies;

public class FizzRule : IFizzBuzzRule
{
    public bool IsMatch(int number) => number % 3 == 0;

    public string Output => "Fizz";
}