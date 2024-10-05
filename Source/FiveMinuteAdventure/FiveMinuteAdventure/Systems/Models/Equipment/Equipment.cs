namespace FiveMinuteAdventure.Systems.Models.Equipment;

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

public static class EquipmentHelper
{
    public static List<EquipmentType> GetWeaponEquipmentTypes()
    {
        return new List<EquipmentType>()
        {
            EquipmentType.Blade,
            EquipmentType.Gun,
            EquipmentType.Staff,
        };
    }
    
    public static List<EquipmentType> GetArmorEquipmentTypes()
    {
        return new List<EquipmentType>()
        {
            EquipmentType.Armor,
            EquipmentType.Barrier,
            EquipmentType.Component,
        };
    }
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
