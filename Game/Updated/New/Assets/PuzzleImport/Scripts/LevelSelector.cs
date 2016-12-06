using UnityEngine;
using System.Collections;

public class LevelSelector : MonoBehaviour {

	private GameObject level1;

	// Use this for initialization
	void Start () {

		level1 = GameObject.Find ("Level1");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.name == "Level1") {

			level1.SetActive (true);
		}
	}
}
