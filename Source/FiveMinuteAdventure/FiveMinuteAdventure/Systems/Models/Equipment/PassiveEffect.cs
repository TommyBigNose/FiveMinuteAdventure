namespace FiveMinuteAdventure.Systems.Models;

public enum PassiveEffectType
{
    None = 0,
    Stat = 1,
    StatPercent = 2,
    BattleTimer = 3,
    InstantKillCount = 4,
    Credits = 5,
    CreditsPercent = 6,
    NormalLootChancePercent = 7,
    RareLootChancePercent = 8,
}

public interface IPassiveEffect
{
    int Id { get; }
    string Name { get; }
    string Description { get; }
    Stats Stats { get; }
    PassiveEffectType PassiveEffectType { get; }
}

public class PassiveEffect : IPassiveEffect
{
    public PassiveEffect(int id, string name, string description, Stats stats, PassiveEffectType passiveEffectType)
    {
        Id = id;
        Name = name;
        Description = description;
        Stats = stats;
        PassiveEffectType = passiveEffectType;
    }

    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public Stats Stats { get; }
    public PassiveEffectType PassiveEffectType { get; }
}