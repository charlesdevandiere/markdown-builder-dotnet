namespace Markdown;

/// <summary>
/// Argument validation helper.
/// </summary>
internal static class ArgumentValidator
{
    public static void ThrowIfNull<T>(T value, string paramName) where T : class
    {
        if (value is null)
        {
            throw new ArgumentNullException(paramName);
        }
    }

    public static void ThrowIfEmpty<T>(T[] value, string paramName, string? message = null)
    {
        if (value.Length == 0)
        {
            throw new ArgumentException(message ?? $"Argument '{paramName}' must not be empty.", paramName);
        }
    }

    public static void ThrowIfNotPositive(int value, string paramName, string? message = null)
    {
        if (value <= 0)
        {
            throw new ArgumentOutOfRangeException(paramName, value, message ?? $"Argument '{paramName}' must be positive.");
        }
    }

    public static void ThrowIfLessThan(int value, int other, string paramName, string? message = null)
    {
        if (value < other)
        {
            throw new ArgumentOutOfRangeException(paramName, value, message ?? $"Argument '{paramName}' must be greater than or equal to {other}.");
        }
    }

    public static void ThrowIfGreaterThan(int value, int other, string paramName, string? message = null)
    {
        if (value > other)
        {
            throw new ArgumentOutOfRangeException(paramName, value, message ?? $"Argument '{paramName}' must be less than or equal to {other}.");
        }
    }

    public static void ThrowIfNotIn(char value, string paramName, params char[] allowed)
    {
        if (Array.IndexOf(allowed, value) < 0)
        {
            throw new ArgumentException($"Argument '{paramName}' must be one of: {string.Join(", ", allowed)}.", paramName);
        }
    }
}
