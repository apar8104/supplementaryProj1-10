namespace Supplement9.Tests;

public class InvalidSequenceExceptionTests
{
    [Fact]
    public void ExceptionShouldHaveDefaultMessage()
    {
        var ex = new InvalidSequenceException();
        Assert.Equal("An invalid sequence was generted.", ex.Message);
    }
}
