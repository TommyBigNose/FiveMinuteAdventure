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
    public void Should_GetAllArmors_When_Valid()
    {
        // Arrange
        // Act
        var result = _sut.GetAllArmors();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Any(_ => EquipmentHelper.GetArmorEquipmentTypes().Contains(_.EquipmentType)), Is.True, "Some returned equipment was not an Armor type");
            Assert.That(result.Count, Is.GreaterThan(1), "Not all armors were returned");
        });
    }
    
    [Test]
    public void Should_GetAllBarriers_When_Valid()
    {
        // Arrange
        // Act
        var result = _sut.GetAllBarriers();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Any(_ => EquipmentHelper.GetArmorEquipmentTypes().Contains(_.EquipmentType)), Is.True, "Some returned equipment was not a Barrier (Armor) type");
            Assert.That(result.Count, Is.GreaterThan(1), "Not all barriers were returned");
        });
    }
    
    [Test]
    public void Should_GetAllComponents_When_Valid()
    {
        // Arrange
        // Act
        var result = _sut.GetAllComponents();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Any(_ => EquipmentHelper.GetArmorEquipmentTypes().Contains(_.EquipmentType)), Is.True, "Some returned equipment was not a Component (Armor) type");
            Assert.That(result.Count, Is.GreaterThan(1), "Not all components were returned");
        });
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
    
    [Test]
    public void Should_GetAllEquipment_When_Valid()
    {
        // Arrange
        // Act
        var result = _sut.GetAllEquipment();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Any(_ => EquipmentHelper.GetWeaponEquipmentTypes().Contains(_.EquipmentType)), Is.True, "Some returned equipment was not a Weapon type");
            Assert.That(result.Any(_ => EquipmentHelper.GetArmorEquipmentTypes().Contains(_.EquipmentType)), Is.True, "Some returned equipment was not an Armor type");
            Assert.That(result.Count, Is.GreaterThan(1), "Not all equipment were returned");
        });
    }
    
    [Test]
    public void Should_GetAllPassiveEffects_When_Valid()
    {
        // Arrange
        // Act
        var result = _sut.GetAllPassiveEffects();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(result.Count, Is.GreaterThan(1), "Not all passive effects were returned");
        });
    }
}