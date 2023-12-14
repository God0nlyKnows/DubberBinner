namespace BuberDinner.Domain.Models;

public abstract class ValueObejct : IEquatable<ValueObejct>
{
    public abstract IEnumerable<object> GetEqualityComponents();

    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
        {
            return false;
        }

        var valueObject = (ValueObejct)obj;

        return GetEqualityComponents()
        .SequenceEqual(valueObject.GetEqualityComponents());
    }

    public static bool operator ==(ValueObejct left, ValueObejct right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(ValueObejct left, ValueObejct right)
    {
        return !Equals(left, right);
    }

    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x?.GetHashCode() ?? 0)
            .Aggregate((x, y) => x ^ y);
    }

    public bool Equals(ValueObejct? other)
    {
        return Equals((object?)other);
    }
}
