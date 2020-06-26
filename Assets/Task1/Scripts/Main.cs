using UnityEngine;

namespace Task1 {
	public class Main : MonoBehaviour {

		[Header("Прямоугольник 1:")]
		[SerializeField]
		private int r1_x;
		[SerializeField]
		private int r1_y;
		[SerializeField]
		private int r1_width;
		[SerializeField]
		private int r1_height;

		[Header("Прямоугольник 2:")]
		[SerializeField]
		private int r2_x;
		[SerializeField]
		private int r2_y;
		[SerializeField]
		private int r2_width;
		[SerializeField]
		private int r2_height;


		// Use this for initialization
		void Start() {
			Rectangle r1 = new Rectangle(new Point(r1_x, r1_y), r1_width, r1_height);
			Rectangle r2 = new Rectangle(new Point(r2_x, r2_y), r2_width, r2_height);

			Debug.Log(Intersection.AreaIntersection(r1, r2));

		}
	}
}