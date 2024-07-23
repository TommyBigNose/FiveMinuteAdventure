namespace FiveMinuteAdventure.Systems.Models;

public class Stats
{
    public int Level { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; }
    public int Magic { get; set; }

    public Stats()
    {
        Level = 1;
        Attack = 1;
        Defense = 1;
        Speed = 1;
        Magic = 1;
    }
    
    public Stats(Stats clone)
    {
        Level = clone.Level;
        Attack = clone.Attack;
        Defense = clone.Defense;
        Speed = clone.Speed;
        Magic = clone.Magic;
    }

    public Stats CompareDifferenceInStats(Stats comparedStats)
    {
        Stats stats = new()
        {
            Level = Level - comparedStats.Level,
            Attack = Attack - comparedStats.Attack,
            Defense = Defense - comparedStats.Defense,
            Speed = Speed - comparedStats.Speed,
            Magic = Magic - comparedStats.Magic
        };

        return stats;
    }
}