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
        int lowCount = 0;

        while (true)
        {
            float value = _generator();

            if (value <= 0.5f)
            {
                lowCount++;
                if (lowCount == 3)
                {
                   throw new InvalidSequenceException("Three consecutive values were ≤ 0.5."); 
                }
            }
            else
            {
                lowCount = 0;
            }
            yield return value;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}