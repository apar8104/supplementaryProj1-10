namespace Supplement9;

public class InvalidSequenceException : Exception
{
    /// <summary>
    /// This gives the invalid sequence message when the invalid sequence
    /// excepton is thrown. 
    /// </summary>
    public InvalidSequenceException()
        : base("An invalid sequence was generated.") {}
    
    /// <summary>
    /// Gives a custom message when invalid sequence exception is thrown. 
    /// </summary>
    /// <param name="message">The custom message to be given. </param>
    public InvalidSequenceException(string message)
        : base(message) {}
}
