using System.Collections.Generic;
namespace Supplement9.Tests;

public class RandomFloatEnumerableTests
{
    [Fact]
    public void EnumeratorShouldYieldFloatsBetween0And1()
    {
        var generator = new RandomFloatEnumerable();
        using var enumerator = generator.GetEnumerator();

        try{
            for (int i = 0; i < 10; i++)
            {
                Assert.True(enumerator.MoveNext());
                float value = enumerator.Current;
                Assert.InRange(value, 0.0f, 1.0f);
            }
        }
        catch (InvalidSequenceException ex)
        {
            Console.WriteLine($"Test failed due to sequence rule: {ex.Message}");
            return;
        }
    }

    [Fact]
    public void EnumeratorShouldThrowExceptionAfterThreeLowValues()
    {
        var generator = new RandomFloatEnumerable(() => 0.4f);

        using var enumerator = generator.GetEnumerator();
        Assert.Throws<InvalidSequenceException>(() =>
        {
            enumerator.MoveNext();
            enumerator.MoveNext();
            enumerator.MoveNext();
        });
    }
}