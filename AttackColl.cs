using System;
using System.IO;
using System.Collections.Generic;

public class AttackColl
{

	readonly string DEFAULTFILELINK = "AttackLibraries/AttackLibrary.txt";
	readonly int DEFAULTTOTALSLOTS = 12;

	string FileLink;
	TextReader Reader;

	//  All possible attacks
	//  Not necessarily all attacks that the specific character
	//  can do
	Attack[] AttackLibrary;

	//  Number attacks in attack library
	int NumOfAttacks;

	//  links to attacks owned by specific character
	List<int> ActiveAttacks;

	int TotalSlots;
	int OccupiedSlots;

	public AttackColl()
	{
		TotalSlots = DEFAULTTOTALSLOTS;
		FileLink = DEFAULTFILELINK;
		Init();
	}

	public AttackColl(string FileLink)
	{
		TotalSlots = DEFAULTTOTALSLOTS;
		this.FileLink = FileLink;
		Init();
	}

	public AttackColl(int TotalSlots)
	{
		this.TotalSlots = TotalSlots;
		FileLink = DEFAULTFILELINK;
		Init();
	}

	/**
	 *  This is the ideal constructor.
	 *  Please use it whenever possible.
	 */ 
	public AttackColl(int TotalSlots, string FileLink)
	{
		this.TotalSlots = TotalSlots;
		this.FileLink = FileLink;
		Init();
	}

	public AttackColl(string FileLink, int TotalSlots)
	{
		this.TotalSlots = TotalSlots;
		this.FileLink = FileLink;
		Init();
	}

	public void SetFileLink(string FileLink)
	{
		this.FileLink = FileLink;
		Reader = File.OpenText(FileLink);
		NumOfAttacks = int.Parse(Reader.ReadLine());
		AttackLibrary = new Attack[NumOfAttacks];
		ActiveAttacks = new List<int>();

		string Input;
		int x = 0;
		while((Input = Reader.ReadLine()) != null)
		{
			AttackLibrary[x] = new Attack(Input);
			x++;
		}
		Reader.Close();
	}

	public void SetSlots(int TotalSlots)
	{
		this.TotalSlots = TotalSlots;
	}

	public void AddSlots(int Slots)
	{
		TotalSlots += Slots;
	}

	void Init()
	{
		OccupiedSlots = 0;
		SetFileLink(FileLink);
	}

	public void AddAttack(int Link)
	{
		Attack a = AttackLibrary[Link];
		int aSize = a.Slots;

		if(OccupiedSlots + aSize > TotalSlots)
		{
			/**
			 *  TODO
			 *  There isn't enough room in your slots to hold
			 *  the attack given by the link
			 */
		}
		else
		{
			if(ActiveAttacks.Contains(Link))
			{
				/**
				 *  TODO
				 *  The attack is already in your attack collection
				 */
			}
			else
			{
				ActiveAttacks.Add(Link);
				OccupiedSlots += aSize;
			}
		}
	}

	public void AddAttack(Attack a)
	{
		int Link = a.Id;
		AddAttack(Link);
	}

	public void RemoveAttack(Attack a)
	{
		int Link = a.Id;
		RemoveAttack(Link);
	}

	public void RemoveAttack(int Link)
	{
		if(ActiveAttacks.Contains(Link))
		{
			int aSize = (int) AttackLibrary[Link].Slots;
			OccupiedSlots -= aSize;
			ActiveAttacks.Remove(Link);
		}
	}

	public void Print()
	{
		for(int x = 0; x < NumOfAttacks; x++)
		{
			AttackLibrary[x].Print();
		}
	}
}