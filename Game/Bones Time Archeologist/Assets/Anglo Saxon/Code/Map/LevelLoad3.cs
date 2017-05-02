using UnityEngine;
using System.Collections;

public class LevelLoad3 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
        {
            if (Input.GetKeyDown(KeyCode.R))
                Application.LoadLevel(1);
        }
        {
            if (Input.GetKeyDown(KeyCode.P))
                Application.LoadLevel(4);
        }
    }

	public void ChangeToScene(string sceneName)
	{
		Application.LoadLevel("Map");
	}

}