using System;

public class Fighter : Character
{
	AttackColl Attacks;

	public Fighter()
	{
		Attacks = new AttackColl();
	}

	public Fighter(string FileLink)
	{
		Attacks = new AttackColl(FileLink);
	}

	public Fighter(int TotalSlots)
	{
		Attacks = new AttackColl(TotalSlots);
	}

	public Fighter(int TotalSlots, string FileLink)
	{
		Attacks = new AttackColl(TotalSlots, FileLink);
	}

	public Fighter(string FileLink, int TotalSlots)
	{
		Attacks = new AttackColl(FileLink, TotalSlots);
	}

	public void SetFileLink(string FileLink)
	{
		Attacks.SetFileLink(FileLink);
	}

	public void SetSlots(int TotalSlots)
	{
		Attacks.SetSlots(TotalSlots);
	}

	public void AddSlots(int Slots)
	{
		Attacks.AddSlots(Slots);
	}

	public void AddAttack(int Link)
	{
		Attacks.AddAttack(Link);
	}

	public void AddAttack(Attack a)
	{
		Attacks.AddAttack(a);
	}

	public void RemoveAttack(int Link)
	{
		Attacks.RemoveAttack(Link);
	}

	public void RemoveAttack(Attack a)
	{
		Attacks.RemoveAttack(a);
	}

	public void Print()
	{
		Attacks.Print();
	}

	void Fight()
	{
		/**
		 *  TODO
		 */
	}
}