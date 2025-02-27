namespace Supplement9.Tests;

public class InvalidSequenceExceptionTests
{
    [Fact]
    public void ExceptionShouldHaveDefaultMessage()
    {
        var ex = new InvalidSequenceException();
        Assert.Equal("An invalid sequence was generated.",ex.Message);
    }

    [Fact]
    public void ExceptionShouldAcceptCustomMessage()
    {
        var ex = new InvalidSequenceException("Custom error message");
        Assert.Equal("Custom error message", ex.Message);
    }
}
