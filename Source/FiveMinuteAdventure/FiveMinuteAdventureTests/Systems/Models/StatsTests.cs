namespace FiveMinuteAdventureTests.Systems.Models;

public class StatsTests
{
    private Stats _sut;
    
    [SetUp]
    public void Setup()
    {
        _sut = new Stats();
    }

    [Test]
    public void Should_Clone_When_GivenAnotherModel()
    {
        // Arrange
        Stats clonedStats = new Stats()
        {
            Level = 10,
            Attack = 5,
            Defense = 3,
            Speed = 4,
            Magic = 2
        };
        
        // Act
        var result = new Stats(clonedStats);
        
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Level == clonedStats.Level);
            Assert.That(result.Attack == clonedStats.Attack);
            Assert.That(result.Defense == clonedStats.Defense);
            Assert.That(result.Speed == clonedStats.Speed);
            Assert.That(result.Magic == clonedStats.Magic);
        });
    }
    
    [Test]
    public void Should_Compare_When_GivenAnotherModel()
    {
        // Arrange
        Stats statsToCompare = new Stats()
        {
            Level = 2,
            Attack = 3,
            Defense = 4,
            Speed = 5,
            Magic = 2
        };
        
        // Act
        var result = _sut.CompareDifferenceInStats(statsToCompare);
        
        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Level == _sut.Level - statsToCompare.Level);
            Assert.That(result.Attack == _sut.Attack - statsToCompare.Attack);
            Assert.That(result.Defense == _sut.Defense - statsToCompare.Defense);
            Assert.That(result.Speed == _sut.Speed - statsToCompare.Speed);
            Assert.That(result.Magic == _sut.Magic - statsToCompare.Magic);
        });
    }
}