using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour 
{
	//public RaycastHit hit;

	void Start () 
	{
		
	}

	void Update ()
	{
		if (Input.GetButtonDown ("Fire1")) 
		{
			//Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			//RaycastHit hit;
			//if (Physics.Raycast (ray, -Vector3.up, out hit))

			if (gameObject.tag == "Rome") 
				
			{
				//SceneManager.LoadScene ("RomePrototype", LoadSceneMode.Additive);
				SceneManager.LoadScene ("RomePrototype", LoadSceneMode.Single);
			}
		
		}

	}
}