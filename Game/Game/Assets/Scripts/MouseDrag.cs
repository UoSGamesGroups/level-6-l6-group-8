using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseDrag : MonoBehaviour {

	private bool dragging = false;
	private float distance;
	public string pieceStatus = " ";
	public float myScale = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (dragging) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Vector2 rayPoint = ray.GetPoint (distance);
			transform.position = rayPoint;	
		}
	}

	void OnMouseDown()
	{
		distance = Vector2.Distance (transform.position, Camera.main.transform.position);
		dragging = true;
	}

	void OnMouseUp()
	{
		dragging = false;
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.name == gameObject.name) 
		{
			transform.position = col.gameObject.transform.position;
			pieceStatus = "locked";
			GetComponent <BoxCollider2D>().enabled = false;
			Debug.Log ("Hit");
			transform.localScale = new Vector2 (myScale, myScale);
		}
	}
}
