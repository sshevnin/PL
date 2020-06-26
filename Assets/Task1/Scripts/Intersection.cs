using System;

namespace Task1 {
	public static class Intersection {
		public static int AreaIntersection(Rectangle r1, Rectangle r2) {
			int x = r1.DownLeftAngle.X;

			int left = Math.Max(r1.DownLeftAngle.X, r2.DownLeftAngle.X);
			int top = Math.Min(r1.TopRightAngle.Y, r2.TopRightAngle.Y);
			int right = Math.Min(r1.TopRightAngle.X, r2.TopRightAngle.X);
			int bottom = Math.Max(r1.DownLeftAngle.Y, r2.DownLeftAngle.Y);

			int width = right - left;
			int height = top - bottom;

			if (width < 0 || height < 0) return 0;

			return width * height;
		}
	}
}