using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Waypoint : MonoBehaviour 
{
	public bool canMove;
	public bool waypoint1;
	public bool waypoint2;
	public bool waypoint3;
	public bool waypoint4;
	public bool waypoint5;
    public bool waypoint6;
    public bool waypoint7;


	public GameObject[] counters;

	GameObject Character;
	GameObject WaypointOne; 
	GameObject WaypointTwo;
	GameObject WaypointThree;
	GameObject WaypointFour;
	GameObject WaypointFive;
    GameObject WaypointSix;
    GameObject WaypointSeven;

	public GameObject PanelLevel1;

    public Animation animation;

	public float speed = 10000.0f;

	// Use this for initialization
	void Start () 
	{
        animation = GetComponent<Animation>();
		canMove = false;
		waypoint2 = false;

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
        WaypointSix = GameObject.Find("Waypoint6");
        WaypointSeven = GameObject.Find("Waypoint7");

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
			if (canMove == true && waypoint1 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointTwo.transform.position, Time.deltaTime * speed);
                PlayWaypoint1();
				waypoint1 = false;
			}

			if (canMove == true && waypoint2 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointThree.transform.position, Time.deltaTime * speed);
                PlayWaypoint2();
                waypoint2 = false;
			}

			if (canMove == true && waypoint3 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointFour.transform.position, Time.deltaTime * speed);
                waypoint3 = false;
			}

			if (canMove == true && waypoint4 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointFive.transform.position, Time.deltaTime * speed);
                waypoint4 = false;
			}

			if (canMove == true && waypoint5 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointSix.transform.position, Time.deltaTime * speed);
                waypoint5 = false;
			}

            if (canMove == true && waypoint6 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointSeven.transform.position, Time.deltaTime * speed);
                waypoint6 = false;
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
			if (canMove == true && waypoint3 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointTwo.transform.position, Time.deltaTime * speed);
				waypoint3 = false;
			}

			if (canMove == true && waypoint2 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointOne.transform.position, Time.deltaTime * speed);
				waypoint2 = false;
			}

			if (canMove == true && waypoint4 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointThree.transform.position, Time.deltaTime * speed);
				waypoint4 = false;

			}

			if (canMove == true && waypoint5 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointFour.transform.position, Time.deltaTime * speed);
				waypoint5 = false;

			}

            if (canMove == true && waypoint6 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointFive.transform.position, Time.deltaTime * speed);
				waypoint6 = false;

			}

            if (canMove == true && waypoint7 == true) {
				transform.position = Vector3.MoveTowards (transform.position, WaypointSix.transform.position, Time.deltaTime * speed);
				waypoint7 = false;

			}

			break;
		}
	}

	public void Select (string Select)
	{
		switch (Select) 
		{
		case "Select":
			Debug.Log ("selectSelected");
			if (waypoint1 == true) {
				PanelLevel1.SetActive (true);
			}
			break;
		}
	}

	void OnTriggerEnter (Collider col)
	{			
			if (col.gameObject.name == "Waypoint1") {
			canMove = true;
			waypoint1 = true;
				Debug.Log ("Collider Hit");
			}

		if (col.gameObject.name == "Waypoint2"){
			waypoint2 = true;
			canMove = true;
			Debug.Log ("Collider Hit");
		}

		if (col.gameObject.name == "Waypoint3") {
			waypoint3 = true;
			canMove = true;
			Debug.Log ("Collider Hit");
		}

		if (col.gameObject.name == "Waypoint4") {
			waypoint4 = true;
			canMove = true;
			Debug.Log ("Collider Hit");
		}

		if (col.gameObject.name == "Waypoint5") {
			waypoint5 = true;
			canMove = true;
			Debug.Log ("Collider Hit");
		}

        if (col.gameObject.name == "Waypoint6")
        {
            waypoint6 = true;
            canMove = true;
            Debug.Log("Collider Hit");
        }

        if (col.gameObject.name == "Waypoint7")
        {
            waypoint7 = true;
            canMove = true;
            Debug.Log("Collider Hit");
        }

    }

    void PlayWaypoint1()
    {
       animation.Play("BonesMovement");
    }

    void PlayWaypoint2()
    {
        animation.Play("Waypoint2To3");
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
