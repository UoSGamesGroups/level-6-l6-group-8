using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown ("E")) 
		{
			SceneManager.LoadScene ("Words", LoadSceneMode.Single);
		}
	}
}
