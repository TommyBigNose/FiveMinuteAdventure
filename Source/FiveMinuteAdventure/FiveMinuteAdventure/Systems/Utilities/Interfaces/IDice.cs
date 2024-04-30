namespace FiveMinuteAdventure.Systems.Utilities.Interfaces;

public interface IDice
{
	/// <summary>
	/// Random number greater than or equal to min, less than max
	/// </summary>
	/// <param name="minInclusive"></param>
	/// <param name="maxExclusive"></param>
	/// <returns></returns>
	int GetDiceRoll(int minInclusive, int maxExclusive);
}