using System.Collections;
using System.Collections.Generic;

namespace Supplement9;

public class RandomFloatEnumerable : IEnumerable<float>
{
    public RandomFloatEnumerable()
    {
        throw new NotImplementedException();
    }

    public RandomFloatEnumerable(Func<float> generator)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<float> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}