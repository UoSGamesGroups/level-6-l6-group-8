using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Waypoint : MonoBehaviour 
{
	public bool canMove;

	public GameObject[] counters;

	GameObject Character;
	GameObject WaypointOne; 
	GameObject WaypointTwo;
	GameObject WaypointThree;

	// Use this for initialization
	void Start () 
	{
		canMove = false;

		counters = GameObject.FindGameObjectsWithTag ("Waypoint");
		for (int i = 0; i < counters.Length; i++) {
			Debug.Log("counter Number "+i+ "is named " +counters[i].name);
		}

	//	WaypointOne = GameObject.Find ("Counters/Counter/WaypointAngloHut");
		Character = GameObject.Find ("Bones");
		WaypointOne = GameObject.Find ("WaypointAngloHut");
		WaypointTwo = GameObject.Find ("WaypointAngloCastle");

	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


	public void Right (string Right)
	{
		switch (Right)
		{
		case "Right":

			Debug.Log ("moveRight");
			break;
		}
	}

	public void Left (string Left)
	{
		switch (Left)
		{
		case "Left":



			Debug.Log ("moveLeft");
			break;
		}
	}



	/*
	void CastMovement ()
	{
		{
			//Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			//RaycastHit hit;

			if (Input.GetMouseButtonDown (0))
			{
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
				if (Physics.Raycast(ray, out hit));
				{
					//	Debug.Log ("Hello");
					//if (gameObject.tag = "Hut");
					{
						//	Debug.Log ("YEs");
					}
				}
			}
		}
	}

*/
}
