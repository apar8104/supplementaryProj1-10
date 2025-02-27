namespace Supplement9;

public class QuarterTests
{
    [Theory]
    [InlineData(0.1f, 0.2f, true)]  
    [InlineData(0.3f, 0.4f, true)]  
    [InlineData(0.6f, 0.7f, true)]  
    [InlineData(0.8f, 0.9f, true)]  
    [InlineData(0.1f, 0.3f, false)] 
    [InlineData(0.4f, 0.6f, false)] 
    public void QuarterEqualityOperatorWorksCorrectly(float value1, float value2, bool expected)
    {
        var q1 = new Quarter(value1);
        var q2 = new Quarter(value2);
        Assert.Equal(expected, q1 == q2);
    }

    [Theory]
    [InlineData(0.1f, 0.3f, true)]  
    [InlineData(0.5f, 0.7f, true)]  
    [InlineData(0.8f, 0.7f, false)]
    public void QuarterLessThanOperatorWorksCorrectly(float value1, float value2, bool expected)
    {
        var q1 = new Quarter(value1);
        var q2 = new Quarter(value2);
        Assert.Equal(expected, q1 < q2);
    }
}