using System;
using System.IO;

public class AttackColl
{

	public static void Main()
	{
		AttackColl a = new AttackColl();
		a.Print();
	}

	readonly string DEFAULTFILELINK = "AttackLibrary.txt";

	string fileLink;
	TextReader reader;
	Attack[] attackLibrary;

	int numOfAttacks;

	public AttackColl()
	{
		fileLink = DEFAULTFILELINK;
		init();
	}

	public AttackColl(string fileLink)
	{
		this.fileLink = fileLink;
		init();
	}

	void init()
	{
		reader = File.OpenText(fileLink);
		numOfAttacks = int.Parse(reader.ReadLine());
		attackLibrary = new Attack[numOfAttacks];

		string input;
		int x = 0;
		while((input = reader.ReadLine()) != null)
		{
			attackLibrary[x] = new Attack(input);
			x++;
		}
	}

	void Print()
	{
		for(int x = 0; x < numOfAttacks; x++)
		{
			attackLibrary[x].Print();
		}
	}
}