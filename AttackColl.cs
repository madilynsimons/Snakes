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

	string FileLink;
	TextReader Reader;
	Attack[] AttackLibrary;

	int NumOfAttacks;

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

	void Print()
	{
		for(int x = 0; x < NumOfAttacks; x++)
		{
			AttackLibrary[x].Print();
		}
	}
}