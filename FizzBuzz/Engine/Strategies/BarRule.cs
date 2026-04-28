namespace FizzBuzz.Engine.Strategies;

public class BarRule : IFizzBuzzRule
{
    public bool IsMatch(int number) => number % 7 == 0;
    public string Output => "Bar";
}