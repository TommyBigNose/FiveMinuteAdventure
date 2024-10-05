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
        throw new NotImplementedException();
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