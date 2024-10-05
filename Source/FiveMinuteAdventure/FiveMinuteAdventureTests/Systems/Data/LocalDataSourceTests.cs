namespace FiveMinuteAdventureTests.Systems.Data;

public class LocalDataSourceTests
{
    private IDataSource _sut;
    
    [SetUp]
    public void SetUp()
    {
        _sut = new LocalDataSource();
    }

    [TearDown]
    public void TearDown()
    {

    }

    [Test]
    public void Should_GetAllWeapons_When_Valid()
    {
        // Arrange
        // Act
        var result = _sut.GetAllWeapons();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Any(_ => EquipmentHelper.GetWeaponEquipmentTypes().Contains(_.EquipmentType)), Is.True, "Some returned equipment was not a Weapon type");
            Assert.That(result.Count, Is.GreaterThan(1), "Not all weapons were returned");
        });
    }
}