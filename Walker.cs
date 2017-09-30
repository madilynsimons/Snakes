using System;
using UnityEngine;
using System.Collections.Generic;

public class Walker : MonoBehaviour
{
	class Point
	{
		public float x;
		public float y;

		public Point()
		{
			x = 0; y = 0;
		}

		public Point(float x, float y){
			this.x = x;
			this.y = y;
		}
	}

	Vector2 position;
	Queue<Point> trail;
	Rigidbody2D rg;

	void Start()
	{
		position = new Vector2();
		trail = new Queue<Point>();
		rg = GetComponent<Rigidbody2D> (); 
	}

	public void AddToTrail(float x, float y)
	{
		if (!(x == 0 && y == 0)) {
			Point p = new Point (x, y);
			trail.Enqueue (p);
		}
	}


	void move(Point p)
	{
		rg.gameObject.transform.Translate(p.x, p.y, 0);
	}

	void FixedUpdate () {
		int x = (int) trail.ToArray ().Length;
		if(x > 0 )
		{
			move(trail.Dequeue());
		}
				
	}

}