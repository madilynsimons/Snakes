using System;
using System.IO;
using System.Collections.Generic;

public class AttackColl
{

	public static void Main()
	{
		AttackColl a = new AttackColl();
		a.Print();
	}

	readonly string DEFAULTFILELINK = "AttackLibrary.txt";

	string FileLink;
	TextReader Reader;

	//  All possible attacks
	//  Not necessarily all attacks that the specific character
	//  can do
	Attack[] AttackLibrary;

	//  Number attacks in attack library
	int NumOfAttacks;

	//  links to attacks owned by specific character
	List<Attack> ActiceAttacks;

	public AttackColl()
	{
		FileLink = DEFAULTFILELINK;
		Init();
	}

	public AttackColl(string FileLink)
	{
		this.FileLink = FileLink;
		Init();
	}

	void Init()
	{
		Reader = File.OpenText(FileLink);
		NumOfAttacks = int.Parse(Reader.ReadLine());
		AttackLibrary = new Attack[NumOfAttacks];

		string Input;
		int x = 0;
		while((Input = Reader.ReadLine()) != null)
		{
			AttackLibrary[x] = new Attack(Input);
			x++;
		}
	}

	void AddAttack(int Link)
	{

	}

	void Print()
	{
		for(int x = 0; x < NumOfAttacks; x++)
		{
			AttackLibrary[x].Print();
		}
	}
}