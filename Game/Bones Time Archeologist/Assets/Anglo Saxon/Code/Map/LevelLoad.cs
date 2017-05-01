using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelLoad : MonoBehaviour {

	public bool waypoint1;
    public bool waypoint2;
	public GameObject LevelPanel1;
    public GameObject LevelPanel2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (waypoint1 == true) {
			
			LevelPanel1.SetActive (true);
		}

        if(waypoint2 == true)
        {
            LevelPanel2.SetActive(true);
        }
	}

	void OnTriggerEnter (Collider col)
	{			
		if (col.gameObject.name == "Waypoint1") {
			waypoint1 = true;
			Debug.Log ("Collider Hit");
		}

        if (col.gameObject.name == "Waypoint2")
        {
            waypoint2 = true;
            Debug.Log("Collider 2 Hit");
        }
	}
}
