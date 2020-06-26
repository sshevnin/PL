namespace Task1 {
	public class Rectangle {

		private Point position;
		private int width, height;

		public Rectangle(Point position, int width, int height) {
			this.position = position;
			this.width = width;
			this.height = height;
		}

		public int Width {
			get {return this.width;}
		}

		public int Height {
			get {return this.height;}
		}

		public Point DownLeftAngle {
			get {return this.position;}
		}

		public Point TopRightAngle {
			get { return new Point(this.position.X + this.width, this.position.Y + this.height); }
		}
	}
}
