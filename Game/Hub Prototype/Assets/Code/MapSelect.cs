using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class MapSelect : MonoBehaviour 
{
	public RaycastHit hit;

	public Camera PlayCam;
	public Camera MapCam;

	public bool isMapMode = false;
	public FirstPersonController FpsOff;

	public GameObject LaraMod;

	CursorLockMode wantedMode;

	void Start () 
	{
		PlayCam.GetComponent<Camera>().enabled = true;
		MapCam.GetComponent<Camera>().enabled = false;
	}

	void Update ()
	{
		if (!isMapMode) {
			if (Input.GetKeyUp (KeyCode.E)) 
			{
				Ray ray = Camera.main.ScreenPointToRay (new Vector3 (Screen.width / 2, Screen.height / 2, 0));

				if (Physics.Raycast (ray, out hit, 5)) 
				{
					PlayCam.GetComponent<Camera> ().enabled = false;
					MapCam.GetComponent<Camera> ().enabled = true;
					isMapMode = true;
					FpsOff.enabled = false;
					LaraMod.SetActive(false);
					Cursor.visible = true;
					wantedMode = CursorLockMode.None;
				}
			}
		}
		else if (isMapMode)
		{
			if (Input.GetKeyUp (KeyCode.E)) 
			{
				PlayCam.GetComponent<Camera> ().enabled = true;
				MapCam.GetComponent<Camera> ().enabled = false;
				isMapMode = false;
				FpsOff.enabled = true;
				LaraMod.SetActive(true);
				Cursor.visible = false;
			}
		}
	}
}