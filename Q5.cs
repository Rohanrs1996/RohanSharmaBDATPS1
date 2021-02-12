using System;

class GFG
{
	static bool FindPoint(int x1, int y1, int x2,
						int y2, int x, int y)
	{
		if (x > x1 && x < x2 &&
			y > y1 && y < y2)
			return true;

		return false;
	}

	public static void Main()
	{
		int x1 = -1, y1 = -1,
			x2 = 0, y2 = 0;

		int x = 2, y = 3;

		if (FindPoint(x1, y1, x2, y2, x, y))
			Console.Write("Yes");
		else
			Console.Write("No");
	}
}