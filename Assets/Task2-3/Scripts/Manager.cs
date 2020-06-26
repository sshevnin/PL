using UnityEngine;

namespace Task2_3 {
	public class Manager : MonoBehaviour {

		[SerializeField]
		private GameObject sphere;
		[SerializeField]
		private GameObject cube;
		[SerializeField]
		private GameObject cylinder;
		[SerializeField]
		private int nCreatObject;

		// Use this for initialization
		void Start() {
			for (int i = 0; i < nCreatObject; i++) {
				this.CreateRandomController();
			}
		}

		public void CreateController(TController tController, Vector3 objPosition) {
			GameObject controller = null;

			switch (tController) {
				case TController.Sphere:
					controller = Instantiate(sphere, objPosition, Quaternion.identity);
					break;
				case TController.Cylinder:
					controller = Instantiate(cylinder, objPosition, Quaternion.identity);
					break;
				case TController.Cube:
					controller = Instantiate(cube, objPosition, Quaternion.identity);
					break;
			}

			Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
			controller.GetComponent<MeshRenderer>().material.color = newColor;
		}

		public void CreateRandomController(bool creatEnable = true) {
			TController tController = (TController)System.Enum.GetValues(typeof(TController)).GetValue(Random.Range(1, 3));

			Vector3 objPosition;
			objPosition.x = (float)Random.Range(0, 5);
			objPosition.y = (float)Random.Range(0, 5);
			objPosition.z = (float)Random.Range(0, 5);

			this.CreateController(tController, objPosition);
		}
	}
}