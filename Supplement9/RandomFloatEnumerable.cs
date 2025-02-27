using System.Collections;
using System.Collections.Generic;

namespace Supplement9;

public class RandomFloatEnumerable : IEnumerable<float>
{
    private readonly Random _random;
    private readonly Func<float> _generator;
    public RandomFloatEnumerable()
    {
        _random = new Random();
        _generator = () => (float)_random.NextDouble();
    }

    public RandomFloatEnumerable(Func<float> generator)
    {
        _generator = generator ?? throw new ArgumentNullException(nameof(generator));
    }

    public IEnumerator<float> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}