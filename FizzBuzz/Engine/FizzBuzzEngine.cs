using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Engine.Strategies;

namespace FizzBuzz.Engine;

public class FizzBuzzEngine(IEnumerable<IFizzBuzzRule> rules)
{
    private string Evaluate(int number)
    {
        var result = string.Concat(rules
            .Where(r => r.IsMatch(number))
            .Select(r => r.Output));

        return string.IsNullOrEmpty(result)
            ? number.ToString()
            : result;
    }

    public void Run(int limit = 100)
    {
        var engine = new FizzBuzzEngine(rules);

        for (var i = 1; i <= limit; i++)
            Console.WriteLine(engine.Evaluate(i));
    }
}