using UnityEngine;
using System.Collections;


public class MouseDrag : MonoBehaviour {

	public bool dragging = false;
    public bool moveable = false;
	private float distance;
	public float myScale = 0.5f;
	public float pickupScale = 1.0f;
	public bool pieceDropped;
    public bool correctPlace;
    public bool wrongPosition;


    // Use this for initialization
    void Start () {
              
	}
	
	// Update is called once per frame
	void Update () {
		//This is used to find the position of the mouse to be able to move the object.
		if (dragging) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Vector2 rayPoint = ray.GetPoint (distance);
			transform.position = rayPoint;
		}
	}

	void OnMouseDown()
	{
		//This is used to pick up the game object.
		distance = Vector2.Distance (transform.position, Camera.main.transform.position);
		dragging = true;
        //This changes the game object color when it is picked up.
        //GetComponent<Renderer>().material.color = Color.magenta;
        //transform.localScale = new Vector2 (pickupScale, pickupScale);#

        
    }

	void OnMouseUp()
	{
		//This is used to place the game object in the correct place.
		dragging = false;
        //If the game object is in the correct place it changes the color to green.
        if (pieceDropped == true && moveable == true && wrongPosition == true)
		{
			//GetComponent<Renderer> ().material.color = Color.green;
			//This start the IEnumerator SetPieceColor.
			//StartCoroutine (SetPieceColor ());
            StartCoroutine(LockPiece());    
        }

        /*if(wrongPosition == true && scoreValue >= 1)
        {
           gameController.MinusScore(scoreValue);
        }*/

        if (pieceDropped == true && moveable == true && correctPlace == true)
        {
            //GetComponent<Renderer> ().material.color = Color.green;
            //This start the IEnumerator SetPieceColor.
            //StartCoroutine (SetPieceColor ());
            StartCoroutine(LockPiece());
        }

        /*if (correctPlace == false && moveable == true)
		{
			//This changes the game object to red if it is in the incorrect place.
			GetComponent<Renderer>().material.color = Color.red;
		}*/
        //transform.localScale = new Vector2 (myScale, myScale);
    }

	/*IEnumerator SetPieceColor()
	{
		//This sets the color to green.
		GetComponent<Renderer> ().material.color = Color.green;
		//This waits for half a sencond.
		yield return new WaitForSeconds (0.5f);
		//This sets it back to the correct color.
		GetComponent<Renderer> ().material.color = Color.white;
	}*/

    IEnumerator LockPiece()
    {
        GetComponent <BoxCollider2D>().enabled = false;
        GetComponent<MouseDrag>().enabled = false;
        yield return new WaitForSeconds(0.05f);
        GetComponent<BoxCollider2D>().enabled = true;
        GetComponent<MouseDrag>().enabled = true;
    }

    void OnTriggerEnter2D (Collider2D col)
	{
		//This looks to see if the game object and the colider are the same name.
		if (col.gameObject.name == gameObject.name) 
		{
            moveable = true;
			transform.position = col.gameObject.transform.position;
			//This deactivates the box collider so that it cant be moved if in the correct position.
			//GetComponent <BoxCollider2D>().enabled = false;
            //GetComponent<MouseDrag>().enabled = false;
			Debug.Log ("Hit");
			pieceDropped = true;
            //transform.localScale = new Vector2 (myScale, myScale);
            correctPlace = true;
            wrongPosition = false;
        }
        

        if (col.gameObject.name != gameObject.name) 
		{
			pieceDropped = true;
            moveable = true;
            wrongPosition = true;
            transform.position = col.gameObject.transform.position;
            //transform.localScale = new Vector2 (myScale, myScale);
        }
    }
}
