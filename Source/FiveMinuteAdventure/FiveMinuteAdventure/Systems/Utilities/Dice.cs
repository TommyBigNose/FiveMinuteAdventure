namespace FiveMinuteAdventure.Systems.Utilities;

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