#if !NET8_0_OR_GREATER
public struct Int128 : IComparable<Int128>, IEquatable<Int128>
{
    private readonly long high;
    private readonly ulong low;

    public Int128(long high, ulong low)
    {
        this.high = high;
        this.low = low;
    }

    public static Int128 operator +(Int128 left, Int128 right)
    {
        ulong sumLow = left.low + right.low;
        long sumHigh = left.high + right.high + (sumLow < left.low ? 1 : 0);
        return new Int128(sumHigh, sumLow);
    }

    public static Int128 operator -(Int128 left, Int128 right)
    {
        ulong diffLow = left.low - right.low;
        long diffHigh = left.high - right.high - (diffLow > left.low ? 1 : 0);
        return new Int128(diffHigh, diffLow);
    }

    public static bool operator ==(Int128 left, Int128 right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Int128 left, Int128 right)
    {
        return !left.Equals(right);
    }

    public static bool operator <(Int128 left, Int128 right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(Int128 left, Int128 right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(Int128 left, Int128 right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(Int128 left, Int128 right)
    {
        return left.CompareTo(right) >= 0;
    }

    public int CompareTo(Int128 other)
    {
        if (high < other.high)
        {
            return -1;
        }
        else if (high > other.high)
        {
            return 1;
        }
        else if (low < other.low)
        {
            return -1;
        }
        else if (low > other.low)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public bool Equals(Int128 other)
    {
        return high == other.high && low == other.low;
    }

    public override bool Equals(object? obj)
    {
        return obj is Int128 other && Equals(other);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + high.GetHashCode();
            hash = hash * 23 + low.GetHashCode();
            return hash;
        }
    }

    public override string ToString()
    {
        return $"{high}{low:D19}";
    }
}
#else
[assembly: TypeForwardedTo(typeof(System.Int128))]
#endif
