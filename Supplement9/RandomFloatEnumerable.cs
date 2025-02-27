using System.Collections;
using System.Collections.Generic;

namespace Supplement9;

public class RandomFloatEnumerable : IEnumerable<float>
{
    private readonly Random _random;
    private readonly Func<float> _generator;

    /// <summary>
    /// Initializes a new instance of the RandomFloatEnumerable class using
    /// a random number generator. 
    /// </summary>
    public RandomFloatEnumerable()
    {
        _random = new Random();
        _generator = () => (float)_random.NextDouble();
    }

    /// <summary>
    /// Initializes a new instance with a custom numbr generator. 
    /// </summary>
    /// <param name="generator">Generates a floating point number. </param>
    /// <exception cref="ArgumentNullException">Thrown if generator is null. 
    /// </exception>
    public RandomFloatEnumerable(Func<float> generator)
    {
        _generator = generator ?? throw new ArgumentNullException(nameof(generator));
    }

        /// <summary>
    /// Returns an enumerator that iterates through an infinite sequence of 
    /// random numbers. 
    /// </summary>
    /// <returns>An enumerator that yields floating point numbers between 
    /// 0.0 and 1.0. </returns>
    /// <exception cref="InvalidSequenceException">Throws exception if three 
    /// consecutive numbers are less than or equal to 0.5. </exception>
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