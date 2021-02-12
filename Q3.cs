using System;

class Test
{
	static float findArea(float a, float b,
						float c)
	{
		if (a < 0 || b < 0 || c < 0 ||
		(a + b <= c) || a + c <= b ||
			b + c <= a)
		{
			Console.Write("Not a valid triangle");
			System.Environment.Exit(0);
		}
		float s = (a + b + c) / 2;
		return (float)Math.Sqrt(s * (s - a) *
							(s - b) * (s - c));
	}

	public static void Main()
	{
		float a = 3.0f;
		float b = 4.0f;
		float c = 5.0f;

		Console.Write("Area is " + findArea(a, b, c));
	}
}