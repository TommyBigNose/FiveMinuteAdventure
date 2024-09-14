namespace FiveMinuteAdventure.Systems.Models;

public class LootTable
{
    public int Id { get; set; }
    public int ChanceForNormalLoot { get; set; }
    public int ChanceForRareLoot { get; set; }
    public List<IEquipment> PotentialLootCommon { get; set; } = new();
    public List<IEquipment> PotentialLootRare { get; set; } = new();
}