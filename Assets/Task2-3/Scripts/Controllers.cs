using UnityEngine;
using UnityEngine.EventSystems;

namespace Task2_3 {
	public abstract class Controllers : MonoBehaviour {

		public float speed;
		public Vector3 direction;

		// Use this for initialization
		void Start() {
			this.speed = 0.1f;
		}

		private void OnMouseDown() {
			if (!EventSystem.current.IsPointerOverGameObject()) {
				this.GetComponent<MeshRenderer>().material.color = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1.0f);
			}
		}

		void OnMouseDrag() {
			if (!EventSystem.current.IsPointerOverGameObject()) {
				direction = new Vector3(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"), 0f);
				this.transform.Translate(direction.normalized * speed);
			}
		}
	}
}