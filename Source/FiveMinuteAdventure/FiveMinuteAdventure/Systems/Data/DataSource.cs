namespace FiveMinuteAdventure.Systems.Data;

public interface IDataSource
{
    List<Armor> GetAllArmors();
    List<Barrier> GetAllBarriers();
    List<Weapon> GetAllWeapons();
    List<IEquipment> GetAllEquipment();
    List<IPassiveEffect> GetAllPassiveEffects();
}

public class LocalDataSource : IDataSource
{
    public List<Armor> GetAllArmors()
    {
        throw new NotImplementedException();
    }

    public List<Barrier> GetAllBarriers()
    {
        throw new NotImplementedException();
    }

    public List<Weapon> GetAllWeapons()
    {
        List<Weapon> weapons = new()
        {
            new Weapon(id: 100,
                name: "Saber",
                description: "A mass produced energy blade.",
                stats: new Stats()
                {
                    Level = 1,
                    Attack = 1,
                    Defense = 1,
                    Speed = 1,
                    Magic = 0,
                },
                equipmentType: EquipmentType.Blade,
                passiveEffects: new List<PassiveEffect>()),
            new Weapon(id: 101,
                name: "Brand",
                description: "An enhanced energy blade used by more advanced users.",
                stats: new Stats()
                {
                    Level = 2,
                    Attack = 2,
                    Defense = 1,
                    Speed = 2,
                    Magic = 0,
                },
                equipmentType: EquipmentType.Blade,
                passiveEffects: new List<PassiveEffect>())
        };
        return weapons;
    }

    public List<IEquipment> GetAllEquipment()
    {
        throw new NotImplementedException();
    }

    public List<IPassiveEffect> GetAllPassiveEffects()
    {
        throw new NotImplementedException();
    }
}