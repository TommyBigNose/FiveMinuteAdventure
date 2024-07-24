namespace FiveMinuteAdventure.Systems.Utilities;

public interface IDice
{
    /// <summary>
    /// Random number greater than or equal to min, less than max
    /// </summary>
    /// <param name="minInclusive"></param>
    /// <param name="maxExclusive"></param>
    /// <returns></returns>
    int GetDiceRoll(int minInclusive, int maxExclusive);
}

/// <inheritdoc cref="IDice"/>
public class Dice : IDice
{
    readonly Random _random;

    public Dice()
    {
        _random = new Random();
    }
    
    public int GetDiceRoll(int minInclusive, int maxExclusive)
    {
        return _random.Next(minInclusive, maxExclusive);
    }
}