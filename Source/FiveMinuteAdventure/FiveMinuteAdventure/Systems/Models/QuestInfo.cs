namespace FiveMinuteAdventure.Systems.Models;

public class QuestInfo
{
    public int Id { get; set; }
    public string Name { get; set; } = "No quest name given";
    public int RecommendedLevel { get; set; }
    public int NumberOfEnemies { get; set; }
    public LootTable LootTable { get; set; } = new();
}