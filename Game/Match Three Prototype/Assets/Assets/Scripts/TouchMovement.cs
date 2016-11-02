using UnityEngine;
using System.Collections;

public class TouchMovement : MonoBehaviour {

	public float speed = 0.05f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (){
			if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) {
			
				Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

				transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
			}
		}
	}