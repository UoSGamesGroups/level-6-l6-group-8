using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel(1);
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Application.LoadLevel("Map");
        if (Input.GetKeyDown(KeyCode.R))
            Application.LoadLevel(1);
    }
}
