namespace Supplement9;

public class InvalidSequenceException : Exception
{
    public InvalidSequenceException()
        : base("An invalid sequence was generated.") {}
    
    public InvalidSequenceException(string message)
        : base(message) {}
}
