namespace FizzBuzz.Engine.Strategies;

public interface IFizzBuzzRule
{
    bool IsMatch(int number);
    string Output { get; }
}