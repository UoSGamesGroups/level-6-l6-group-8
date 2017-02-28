using UnityEngine;
using System.Collections;

public class ShowArtifact : MonoBehaviour {

    public GameController gameController;
    public bool levelEnd = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (gameController.score == 16)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            levelEnd = true;
        }

    }

    IEnumerator LevelEnd()
    {
        levelEnd = true;
        yield return new WaitForSeconds(60);
        Application.Quit();
    }
}
