using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Task4 {
	public class Observer : MonoBehaviour {

		public static event EventHandler ObserverCall;

		private List<GameObject> cache;
		private static Observer instance;

		private Observer() {

		}

		public static Observer GetInstance() {
			if (instance == null)
				instance = new Observer();
			return instance;
		}

		// Use this for initialization
		private void Start() {

			this.cache = new List<GameObject>();

			var objs = SceneManager.GetActiveScene().GetRootGameObjects();

			foreach (var obj in objs) {
				if (obj.GetComponent<Publisher>()) {
					this.cache.Add(obj);
				}
			}
		}
	}
}