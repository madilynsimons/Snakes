//  Attack.cs

 using System;

 public class Attack
 {
 	readonly int DEFAULTID = -1;
 	readonly int DEFAULTPP = 20;
 	readonly string DEFAULTNAME = null;
 	readonly Size DEFAULTSIZE = Size.ONE;

 	int id;
 	string name;
 	Size size;
 	int maxPP, currentPP;

 	/**  Constructors **/
 	public Attack()
 	{
 		id = DEFAULTID;
 		name = DEFAULTNAME;
 		maxPP = DEFAULTPP;
 		size = DEFAULTSIZE;

 		init();
  	}

 	public Attack(Attack a)
 	{
 		id = a.id;
 		name = a.name;
 		maxPP = a.maxPP;
 		size = a.size;

 		init();
 	}

 	public Attack(string input)
 	{
 		string[] space = new string[]{" "};
 		string[] parsed;

 		parsed = input.Split(space, StringSplitOptions.None);

 		id = int.Parse(parsed[0]);
 		name = parsed[1];
 		maxPP = int.Parse(parsed[2]);

 		int size = int.Parse(parsed[3]);

 		switch(size)
 		{
 			case 1:
 				this.size = Size.ONE;
 				break;
 			case 2:
 			 	this.size = Size.TWO;
 				break;
 			case 3:
 				this.size = Size.THREE;
 				break;
 			case 4:
 				this.size = Size.FOUR;
 				break;
 			case 6:
 				this.size = Size.SIX;
 				break;
 			default:
 				this.size = Size.NULL;
 				break;
 		}

 		init();

 	}

 	void init()
 	{
 		currentPP = maxPP;
 	}

 	public void Print()
 	{
 		Console.WriteLine("********************");
 		Console.WriteLine("ID = " + id);
 		Console.WriteLine("NAME = " + name);
 		Console.WriteLine("PP = " + maxPP);
 		Console.WriteLine("SIZE = " + size);
 		Console.WriteLine("********************");
 	}

 }