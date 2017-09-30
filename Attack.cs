//  Attack.cs

 using System;

 public class Attack
 {
 	readonly int DEFAULTID = -1;
 	readonly int DEFAULTPP = 20;
 	readonly string DEFAULTNAME = null;
	readonly int DEFAULTSIZE = 1;

 	public int Id;
 	public string Name;
 	public int Slots;
 	public int MaxPP, CurrentPP;

 	/**  Constructors **/
 	public Attack()
 	{
 		Id = DEFAULTID;
 		Name = DEFAULTNAME;
 		MaxPP = DEFAULTPP;
 		Slots = DEFAULTSIZE;

 		Init();
  	}

 	public Attack(Attack a)
 	{
 		Id = a.Id;
 		Name = a.Name;
 		MaxPP = a.MaxPP;
 		Slots = a.Slots;

 		Init();
 	}

 	public Attack(string Input)
 	{
 		string[] Space = new string[]{" "};
 		string[] Parsed;

 		Parsed = Input.Split(Space, StringSplitOptions.None);

 		Id = int.Parse(Parsed[0]);
 		Name = Parsed[1];
 		MaxPP = int.Parse(Parsed[2]);

 		Slots = int.Parse(Parsed[3]);

 		Init();

 	}

 	void Init()
 	{
 		CurrentPP = MaxPP;
 	}

 	public void Print()
 	{
 		Console.WriteLine("********************");
 		Console.WriteLine("ID = " + Id);
 		Console.WriteLine("NAME = " + Name);
 		Console.WriteLine("PP = " + MaxPP);
 		Console.WriteLine("SLOTS = " + Slots);
 		Console.WriteLine("********************");
 	}

 }