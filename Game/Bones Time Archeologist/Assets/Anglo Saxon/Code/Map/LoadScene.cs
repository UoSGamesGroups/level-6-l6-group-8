﻿using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
			if (Input.GetKeyDown(KeyCode.R))
				Application.LoadLevel(0);

	}

	public void ChangeToScene(string sceneName)
	{
		Application.LoadLevel("Puzzle Scene");
	}

    public void ChangeToLevel2 (string sceneName)
    {
        Application.LoadLevel("AngloSaxonPuzle2");
    }
		
}