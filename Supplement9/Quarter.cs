namespace Supplement9;
public class Quarter
{
    private readonly float _value;

    public Quarter(float value)
    {
        if (value < 0.0f || value >= 1.0f)
        {
             throw new ArgumentOutOfRangeException(nameof(value), "Value must be in the range [0.0, 1.0).");
        }
        _value = value;
    }

    private int GetQuarter() => (int)(_value * 4);

    public static bool operator ==(Quarter q1, Quarter q2)
    {
        if (ReferenceEquals(q1, q2)) return true;
        if (q1 is null || q2 is null) return false;
        return q1.GetQuarter() == q2.GetQuarter();
    }

     public static bool operator !=(Quarter q1, Quarter q2) => !(q1 == q2);

     public static bool operator <(Quarter q1, Quarter q2)
    {
        throw new NotImplementedException();
    }

     public static bool operator >(Quarter q1, Quarter q2)
    {
        throw new NotImplementedException();
    }

     public static bool operator <=(Quarter q1, Quarter q2)
    {
        throw new NotImplementedException();
    }

     public static bool operator >=(Quarter q1, Quarter q2)
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object obj)
    {
        throw new NotImplementedException();
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}