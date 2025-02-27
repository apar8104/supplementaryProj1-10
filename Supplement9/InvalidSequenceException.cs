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
    /// 
    /// </summary>
    /// <param name="message"></param>
    public InvalidSequenceException(string message)
        : base(message) {}
}
