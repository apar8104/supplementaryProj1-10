namespace Supplement9;
public class Quarter
{
    private readonly float _value;

    /// <summary>
    /// Initializes a new instance of quarter class. 
    /// </summary>
    /// <param name="value">A floating point number in the range of 
    /// [0.0, 1.0]</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when value 
    /// is outside of valid range. </exception>
    public Quarter(float value)
    {
        if (value < 0.0f || value >= 1.0f)
        {
             throw new ArgumentOutOfRangeException(nameof(value), "Value must be in the range [0.0, 1.0).");
        }
        _value = value;
    }

    /// <summary>
    /// determines the quarter which the value belongs. 
    /// </summary>
    /// <returns>The quarter index (0, 3). </returns>
    private int GetQuarter() => (int)(_value * 4);

    /// <summary>
    /// Determines if two Quarter instances belong to the same quarter.
    /// </summary>
    /// <param name="q1">The first quarter.</param>
    /// <param name="q2">The second quarter.</param>
    /// <returns>True if both instances belong to the same quarter; otherwise, false.</returns>
    public static bool operator ==(Quarter q1, Quarter q2)
    {
        if (ReferenceEquals(q1, q2)) return true;
        if (q1 is null || q2 is null) return false;
        return q1.GetQuarter() == q2.GetQuarter();
    }

    /// <summary>
    /// Determines if two Quarter instances belong to different quarters.
    /// </summary>
    /// <param name="q1">The first quarter.</param>
    /// <param name="q2">The second quarter.</param>
    /// <returns>True if the instances belong to different quarters; otherwise, false.</returns>
     public static bool operator !=(Quarter q1, Quarter q2) => !(q1 == q2);

     public static bool operator <(Quarter q1, Quarter q2)
    {
        if (q1 is null || q2 is null) throw new ArgumentException();
        return q1._value < q2._value;
    }

    public static bool operator <=(Quarter q1, Quarter q2) => q1 < q2 || q1 == q2;

     public static bool operator >(Quarter q1, Quarter q2)
    {
        if (q1 is null || q2 is null) throw new ArgumentNullException();
        return q1._value > q2._value;
    }

     public static bool operator >=(Quarter q1, Quarter q2) => q1 > q2 || q1 == q2;

    public override bool Equals(object obj)
    {
        if (obj is Quarter other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode() => GetQuarter().GetHashCode();
}