using UnityEngine;

namespace Task4 {
	public class Main : MonoBehaviour {

		[SerializeField]
		private GameObject sphere;
		[SerializeField]
		private int nCreatObject;

		// Use this for initialization
		void Start() {
			GameObject controller = null;
			Vector3 objPosition;
			int onjEnable = nCreatObject / 2;

			for (int i = 0; i < nCreatObject; i++) {
				objPosition.x = (float)Random.Range(0, 7);
				objPosition.y = (float)Random.Range(0, 7);
				objPosition.z = (float)Random.Range(0, 7);

				controller = Instantiate(sphere, objPosition, Quaternion.identity);
				controller.GetComponent<MeshRenderer>().material.color = Color.red;
				controller.name = "Sphere_" + i;

				if (i >= onjEnable) {
					controller.SetActive(false);
				}
			}
		}
	}
}