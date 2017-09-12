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
 		currentPP = maxPP;
 		size = DEFAULTSIZE;
  	}

 	public Attack(Attack a)
 	{
 		id = a.id;
 		name = a.name;
 		maxPP = a.maxPP;
 		currentPP = maxPP;
 		size = a.size;
 	}

 }