namespace FiveMinuteAdventure.Systems.Models;

public class Barrier : IEquipment
{
    public Barrier(int id, string name, string description, Stats stats, EquipmentType equipmentType, List<PassiveEffect> passiveEffects)
    {
        Id = id;
        Name = name;
        Description = description;
        Stats = stats;
        EquipmentType = equipmentType;
        PassiveEffects = passiveEffects;
    }
    
    public int Id { get; }
    public string Name { get; }
    public string Description { get; }
    public Stats Stats { get; }
    public EquipmentType EquipmentType { get; }
    public List<PassiveEffect> PassiveEffects { get; }
    
    public int GetPurchaseValue()
    {
        throw new NotImplementedException();
    }

    public int GetSellableValue()
    {
        throw new NotImplementedException();
    }
}