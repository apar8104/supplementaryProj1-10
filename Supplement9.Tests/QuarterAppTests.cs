using System.Security.Cryptography;

namespace Supplement9.Tests;

public class QuarterAppTests
{
    [Fact]
    public void AddingValidQuarterDisplaysCorrectly()
    {
        var app = new QuarterApp();
        app.AddQuarter(0.1f);
        app.AddQuarter(0.3f);

        var output = app.GetQuartersDisplay();
        Assert.Contains("0 - 0.25", output);
        Assert.Contains("0.25 - 0.5", output);
    }

    [Fact]
    public void AddingInvalidQuarterThrowsException()
    {
        var app = new QuarterApp();
        Assert.Throws<ArgumentOutOfRangeException>(() => app.AddQuarter(1.5f));
    }

    [Fact]
    public void EquivalentQuartersAreGrouped()
    {
        var app = new QuarterApp();
        app.AddQuarter(0.1f);
        app.AddQuarter(0.15f);
        app.AddQuarter(0.4f);

        var output = app.GetQuartersDisplay();
        var lines = output.Split("\n");
        Assert.Equal(2, lines.Length);
    }
}