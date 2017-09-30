using System;

public class Walker
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

	void Start()
	{
		position = new Vector2();
		trail = Queue<Point>();
	}

	public AddToTrail(int x, int y)
	{
		Point p = new Point(x, y);
		trail.Enqueue(p);
	}

	void Update()
	{
		if(trail.count != 0)
		{
			move(trail.Dequeue());
		}
	}

	void move(Point p)
	{
		position.x += p.x;
		position.y += p.y;
	}



}