using UnityEngine;
using System.Collections;

public class TouchControls : MonoBehaviour {

	void Update() {

		int nbTouches = Input.touchCount;

		if (nbTouches > 0) {
			for (int i = 0; i < nbTouches; i++) {
				{
					Touch touch = Input.GetTouch (i);

					TouchPhase phase = touch.phase;
				}
			}
		}
	}
}