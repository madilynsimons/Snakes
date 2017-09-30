using System;
using UnityEngine;
using System.Collections.Generic;

public class Walker : MonoBehaviour
{
	class Point
	{
		public int x;
		public int y;

		public Point()
		{
			x = 0; y = 0;
		}

		public Point(int x, int y){
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
			
		for (int x = 0; x < 100; x++) {
			AddToTrail (1, 1);
		}
	}

	public void AddToTrail(int x, int y)
	{
		Point p = new Point(x, y);
		trail.Enqueue(p);
	}

	void Update()
	{

		int x = (int) trail.ToArray ().Length;
		if(x > 0 )
		{
			move(trail.Dequeue());
		}
	}

	void move(Point p)
	{
		position.x = p.x;
		position.y = p.y;
	}

	void FixedUpdate () {
		rg.velocity = position;
	}

}