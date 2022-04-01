using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		public static bool inter = false;
		public static int square = 0;
		public static int left = 0;
		public static int top = 0;
		public static int right = 0;
		public static int bottom = 0;
		public static void Result(Rectangle r1, Rectangle r2)
        {
			for (int i = r1.Top; i <= r1.Bottom; i++)
				for (int j = r1.Left; j <= r1.Right; j++)
					for (int i2 = r2.Top; i2 <= r2.Bottom; i2++)
						for (int j2 = r2.Left; j2 <= r2.Right; j2++)
							if (i == i2 && j == j2)
							{
								left = Math.Min(j,left);
								top = Math.Min(i, top);

								right = Math.Max(j, right);
								bottom = Math.Max(i, bottom);

								inter = true;
							}
		}
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			left = 0;
			right = 0;
			top = 0;
			bottom = 0;
			inter = false;
			Result(r1, r2);
			return inter;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			return Math.Abs((right-left)*(bottom-top));
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			return -1;
		}
	}
}