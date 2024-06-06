#if !NETSTANDARD2_1_OR_GREATER
namespace System.Collections.Generic;

public static class IDictionaryExtensions
{
    public static TValue GetValueOrDefault<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        TKey key
    )
    {
        if (dictionary.TryGetValue(key, out var value))
        {
            return value;
        }

        return default!;
    }

    public static TValue GetValueOrDefault<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        TKey key,
        TValue defaultValue
    )
    {
        if (dictionary.TryGetValue(key, out var value))
        {
            return value;
        }

        return defaultValue;
    }

    public static bool TryAdd<TKey, TValue>(
        this IDictionary<TKey, TValue> dictionary,
        TKey key,
        TValue value
    )
    {
        if (dictionary.ContainsKey(key))
        {
            return false;
        }

        dictionary.Add(key, value);
        return true;
    }
}
#endif
