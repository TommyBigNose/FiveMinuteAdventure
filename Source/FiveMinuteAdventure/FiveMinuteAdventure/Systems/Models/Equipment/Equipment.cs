namespace FiveMinuteAdventure.Systems.Models;

public enum EquipmentType
{
    None = 0,
    Blade = 1,
    Gun = 2,
    Staff = 3,
    Armor = 4,
    Barrier = 5,
    Component = 6
}

public interface IEquipment
{
    int Id { get; }
    string Name { get; }
    string Description { get; }
    Stats Stats { get; }
    EquipmentType EquipmentType { get; }
    List<PassiveEffect> PassiveEffects { get; }
    int GetPurchaseValue();
    int GetSellableValue();
}
