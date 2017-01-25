using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeToScene(string sceneName)
	{
		Application.LoadLevel("Puzzle Scene");
	}
}