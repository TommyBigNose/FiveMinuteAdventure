namespace FiveMinuteAdventure.Systems.Data;

public interface IDataSource
{
    List<Armor> GetAllArmors();
    List<Barrier> GetAllBarriers();
    List<Component> GetAllComponents();
    List<Weapon> GetAllWeapons();
    List<IEquipment> GetAllEquipment();
    List<IPassiveEffect> GetAllPassiveEffects();
}

public class LocalDataSource : IDataSource
{
    public List<Armor> GetAllArmors()
    {
        List<Armor> armors = new()
        {
            new Armor(id: 1000,
                name: "Frame",
                description: "A mass produced exo-skeleton for defense.",
                stats: new Stats()
                {
                    Level = 1,
                    Attack = 0,
                    Defense = 2,
                    Speed = 0,
                    Magic = 1,
                },
                equipmentType: EquipmentType.Armor,
                passiveEffects: new List<PassiveEffect>()),
            new Armor(id: 1001,
                name: "Psy Frame",
                description: "An enhanced exo-skeleton focused on Magic and Speed.",
                stats: new Stats()
                {
                    Level = 2,
                    Attack = 0,
                    Defense = 1,
                    Speed = 3,
                    Magic = 2,
                },
                equipmentType: EquipmentType.Armor,
                passiveEffects: new List<PassiveEffect>())
        };
        return armors;
    }

    public List<Barrier> GetAllBarriers()
    {
        List<Barrier> barriers = new()
        {
            new Barrier(id: 2000,
                name: "Barrier",
                description: "A mass produced energy barrier for defense.",
                stats: new Stats()
                {
                    Level = 1,
                    Attack = 0,
                    Defense = 1,
                    Speed = 0,
                    Magic = 1,
                },
                equipmentType: EquipmentType.Armor,
                passiveEffects: new List<PassiveEffect>()),
            new Barrier(id: 2001,
                name: "Shield",
                description: "An enhanced energy barrier focused on Defense.",
                stats: new Stats()
                {
                    Level = 2,
                    Attack = 0,
                    Defense = 3,
                    Speed = 1,
                    Magic = 1,
                },
                equipmentType: EquipmentType.Armor,
                passiveEffects: new List<PassiveEffect>())
        };
        return barriers;
    }
    
    public List<Component> GetAllComponents()
    {
        List<Component> components = new()
        {
            new Component(id: 3000,
                name: "Barrier",
                description: "A mass produced neural component for balanced effects.",
                stats: new Stats()
                {
                    Level = 1,
                    Attack = 0,
                    Defense = 1,
                    Speed = 0,
                    Magic = 1,
                },
                equipmentType: EquipmentType.Component,
                passiveEffects: new List<PassiveEffect>()),
            new Component(id: 3001,
                name: "Shield",
                description: "An enhanced neural component focused on Speed.",
                stats: new Stats()
                {
                    Level = 2,
                    Attack = 0,
                    Defense = 0,
                    Speed = 4,
                    Magic = 0,
                },
                equipmentType: EquipmentType.Component,
                passiveEffects: new List<PassiveEffect>())
        };
        return components;
    }

    public List<Weapon> GetAllWeapons()
    {
        List<Weapon> weapons = new()
        {
            new Weapon(id: 4000,
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
            new Weapon(id: 4001,
                name: "Brand",
                description: "An enhanced energy blade used by more advanced users.",
                stats: new Stats()
                {
                    Level = 2,
                    Attack = 3,
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