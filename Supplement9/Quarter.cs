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
    public int GetQuarter() => (int)(_value * 4);

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

     /// <summary>
    /// Determines if one Quarter instance is less than another based on its numeric value.
    /// </summary>
    /// <param name="q1">The first quarter.</param>
    /// <param name="q2">The second quarter.</param>
    /// <returns>True if <paramref name="q1"/> is less than <paramref name="q2"/>; otherwise, false.</returns>
    /// <exception cref="ArgumentException">Thrown if either parameter is null.</exception>
     public static bool operator <(Quarter q1, Quarter q2)
    {
        if (q1 is null || q2 is null) throw new ArgumentException();
        return q1._value < q2._value;
    }

     /// <summary>
    /// Determines if one Quarter instance is less than or equal to another.
    /// </summary>
    /// <param name="q1">The first quarter.</param>
    /// <param name="q2">The second quarter.</param>
    /// <returns>True if <paramref name="q1"/> is less than or equal to <paramref name="q2"/>; otherwise, false.</returns>
    public static bool operator <=(Quarter q1, Quarter q2) => q1 < q2 || q1 == q2;

    /// <summary>
    /// Determines if one Quarter instance is greater than another based on its numeric value.
    /// </summary>
    /// <param name="q1">The first quarter.</param>
    /// <param name="q2">The second quarter.</param>
    /// <returns>True if <paramref name="q1"/> is greater than <paramref name="q2"/>; otherwise, false.</returns>
    /// <exception cref="ArgumentException">Thrown if either parameter is null.</exception>
     public static bool operator >(Quarter q1, Quarter q2)
    {
        if (q1 is null || q2 is null) throw new ArgumentNullException();
        return q1._value > q2._value;
    }

    /// <summary>
    /// Determines if one Quarter instance is greater than or equal to another.
    /// </summary>
    /// <param name="q1">The first quarter.</param>
    /// <param name="q2">The second quarter.</param>
    /// <returns>True if <paramref name="q1"/> is greater than or equal to <paramref name="q2"/>; otherwise, false.</returns>
     public static bool operator >=(Quarter q1, Quarter q2) => q1 > q2 || q1 == q2;

    /// <summary>
    /// Determines whether this instance is equal to another object.
    /// </summary>
    /// <param name="obj">The object to compare.</param>
    /// <returns>True if the object is a <see cref="Quarter"/> and belongs to the same quarter; otherwise, false.</returns>
    public override bool Equals(object obj)
    {
        if (obj is Quarter other)
        {
            return this == other;
        }
        return false;
    }

    /// <summary>
    /// Gets the hash code for this instance.
    /// </summary>
    /// <returns>A hash code representing this instance.</returns>
    public override int GetHashCode() => GetQuarter().GetHashCode();
}