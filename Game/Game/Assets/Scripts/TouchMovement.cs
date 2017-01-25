using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TouchMovement : MonoBehaviour {

	/*public float speed = 0.05f;
	public bool isSelected;
	public bool canBeSelected;*/

	int touch1 = 1;
	GameObject originalTile;
	GameObject targetTile;
	bool t2 = true;
	bool t1 = true;

	public string pieceStatus = " ";

	
	// Use this for initialization
	void Start () {

		//canBeSelected = false;
	}
	
	// Update is called once per frame
	void Update (){


		/*if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && gameObject.tag == "Swapable")
		{
			isSelected = true;
			canBeSelected = false;
		}*/

		if (pieceStatus != "locked")
		{
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if(Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				switch (touch1) {
				case 2:
					originalTile = hit.collider.gameObject;
					touch1 = 1;
					t1 = false;
					break;

				case 1:
					targetTile = hit.collider.gameObject;
					touch1 = 2; 
					t2 = false;
					break;
				}
				if (t1 == false && t2 == false) {
					swap (originalTile, targetTile);
					}
				}
			}
		}
	}

	void swap(GameObject org, GameObject tar)
	{
		Vector3 temp = new Vector3 (org.transform.position.x, org.transform.position.y);
		org.transform.position = tar.transform.position;

		tar.transform.position = temp;
		t1 = true;
		t2 = true;
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.name == gameObject.name) 
		{
			transform.position = col.gameObject.transform.position;
			pieceStatus = "locked";
			GetComponent <TouchMovement>().enabled = false;
			GetComponent <Collider>().enabled = false;
		}
	}
}