//  Attack.cs

 using System;

 public class Attack
 {
 	readonly int DEFAULTID = -1;
 	readonly uint DEFAULTPP = 20;
 	readonly string DEFAULTNAME = null;
 	readonly Size DEFAULTSIZE = Size.ONE;

 	int id;
 	string name;
 	Size size;
 	uint maxPP, currentPP;

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

 	void init()
 	{
 		currentPP = maxPP;
 	}

 	public static Attack ParseAttack(string input)
 	{
 		//  TODO
 		return new Attack();
 	}

 }