using UnityEngine;
using System.Collections;
using System.Collections.Generic;
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
	GameObject WaypointFour;
	GameObject WaypointFive;

	public float speed = 10000.0f;

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
		WaypointOne = GameObject.Find ("Waypoint1");
		WaypointTwo = GameObject.Find ("Waypoint2");
		WaypointThree = GameObject.Find ("Waypoint3");
		WaypointFour = GameObject.Find ("Waypoint4");
		WaypointFive = GameObject.Find ("Waypoint5");

	}
	
	// Update is called once per frame
	void Update () 
	{
		//transform.position = Vector3.MoveTowards (transform.position, WaypointTwo.transform.position, Time.deltaTime * speed);
	}


	public void Right (string Right)
	{
		switch (Right)
		{
		case "Right":

			Debug.Log ("moveRight");
			if (canMove == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointTwo.transform.position, Time.deltaTime * speed);
			}
			break;
		}
	}

	public void Left (string Left)
	{
		switch (Left)
		{
		case "Left":

			//canMove = true;
			Debug.Log ("moveLeft");
			//transform.position = Vector3.MoveTowards (transform.position, WaypointOne.transform.position, Time.deltaTime * speed);
			break;
		}
	}




	void OnTriggerEnter (Collider col)
	{			
			if (col.gameObject.name == "Waypoint1") {
			canMove = true;
				Debug.Log ("Collider Hit");
			}
		}
	}


	/*void CastMovement ()
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
