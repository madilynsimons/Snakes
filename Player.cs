using System;
using UnityEngine;
using System.Collections.Generic;

public class Player : Walker
{
	public float speed;

	void Update()
	{
		float hor = Input.GetAxisRaw ("Horizontal");
		float vert = Input.GetAxisRaw ("Vertical");
		AddToTrail (speed * hor, speed * vert);

	}

}