using UnityEngine;

namespace Task4 {
	public class Publisher : MonoBehaviour {

		void Start() {
			Observer.ObserverCall += this.Observer_ObserverCall;
		}

		private void Observer_ObserverCall(object sender, System.EventArgs e) {

		}
	}
}