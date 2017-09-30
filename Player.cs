using System;
using UnityEngine;
using System.Collections.Generic;

public class Player : MonoBehavior
{
	Walker walker;

	void Start()
	{
		walker = new Walker();
	}

	void Update()
	{
		int hor = Input.GetAxisRaw("Horizontal");
		int vert = Input.GetAxisRaw("Vertical");
		walker.AddToTrail(hor, ver);
	}

}