namespace FiveMinuteAdventure.Systems.Models;

public class QuestInfo
{
    public int Id { get; set; }
    public string Name { get; set; } = "No quest name given";
    public int RecommendedLevel { get; set; }
    public int NumberOfEnemies { get; set; }
    public int ChanceForNormalLoot { get; set; }
    public int ChanceForRareLoot { get; set; }
    public List<IEquipment> PotentialLootCommon { get; set; } = new();
    public List<IEquipment> PotentialLootRare { get; set; } = new();
}