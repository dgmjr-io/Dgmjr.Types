#if !NET8_0_OR_GREATER
public struct UInt128 : IComparable<UInt128>, IEquatable<UInt128>
{
    private readonly ulong high;
    private readonly ulong low;

    public UInt128(ulong high, ulong low)
    {
        this.high = high;
        this.low = low;
    }

    public static UInt128 operator +(UInt128 left, UInt128 right)
    {
        ulong sumLow = left.low + right.low;
        ulong sumHigh = left.high + right.high + (sumLow < left.low ? 1UL : 0UL);
        return new UInt128(sumHigh, sumLow);
    }

    public static UInt128 operator -(UInt128 left, UInt128 right)
    {
        ulong diffLow = left.low - right.low;
        ulong diffHigh = left.high - right.high - (diffLow > left.low ? 1UL : 0UL);
        return new UInt128(diffHigh, diffLow);
    }

    public static bool operator ==(UInt128 left, UInt128 right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(UInt128 left, UInt128 right)
    {
        return !left.Equals(right);
    }

    public static bool operator <(UInt128 left, UInt128 right)
    {
        return left.CompareTo(right) < 0;
    }

    public static bool operator <=(UInt128 left, UInt128 right)
    {
        return left.CompareTo(right) <= 0;
    }

    public static bool operator >(UInt128 left, UInt128 right)
    {
        return left.CompareTo(right) > 0;
    }

    public static bool operator >=(UInt128 left, UInt128 right)
    {
        return left.CompareTo(right) >= 0;
    }

    public int CompareTo(UInt128 other)
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

    public bool Equals(UInt128 other)
    {
        return high == other.high && low == other.low;
    }

    public override bool Equals(object? obj)
    {
        return obj is UInt128 other && Equals(other);
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
        return $"{high}{low:D20}";
    }
}
#else
[assembly: TypeForwardedTo(typeof(System.UInt128))]
#endif
