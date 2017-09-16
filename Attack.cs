//  Attack.cs

 using System;

 public class Attack
 {
 	readonly int DEFAULTID = -1;
 	readonly int DEFAULTPP = 20;
 	readonly string DEFAULTNAME = null;
 	readonly Size DEFAULTSIZE = Size.ONE;

 	public int Id;
 	public string Name;
 	public Size Slots;
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

 		int Slots = int.Parse(Parsed[3]);

 		switch(Slots)
 		{
 			case 1:
 				this.Slots = Size.ONE;
 				break;
 			case 2:
 			 	this.Slots = Size.TWO;
 				break;
 			case 3:
 				this.Slots = Size.THREE;
 				break;
 			case 4:
 				this.Slots = Size.FOUR;
 				break;
 			case 6:
 				this.Slots = Size.SIX;
 				break;
 			default:
 				this.Slots = Size.NULL;
 				break;
 		}

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