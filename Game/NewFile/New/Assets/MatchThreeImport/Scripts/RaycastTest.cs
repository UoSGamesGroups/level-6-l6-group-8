using UnityEngine;
using System.Collections;

public class RaycastTest : MonoBehaviour {

	Vector3 touchPosWorld;

	TouchPhase touchPhase = TouchPhase.Ended;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == touchPhase)
		{
			touchPosWorld = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);

			Vector2 touchPosWorld2D = new Vector2 (touchPosWorld.x, touchPosWorld.y);

			RaycastHit2D hitInformation = Physics2D.Raycast (touchPosWorld2D, Camera.main.transform.forward);

			if (hitInformation.collider != null) {

				GameObject touchedObject = hitInformation.transform.gameObject;

				Debug.Log ("Touched " + touchedObject.transform.name);
			}
		}
	}
}