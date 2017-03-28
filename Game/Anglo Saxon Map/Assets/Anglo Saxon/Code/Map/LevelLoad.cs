using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelLoad : MonoBehaviour {

	public bool waypoint1;
	public GameObject LevelPanel1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (waypoint1 == true) {
			
			LevelPanel1.SetActive (true);
		}
	}

	void OnTriggerEnter (Collider col)
	{			
		if (col.gameObject.name == "Waypoint1") {
			waypoint1 = true;
			Debug.Log ("Collider Hit");
		}
	}
}
