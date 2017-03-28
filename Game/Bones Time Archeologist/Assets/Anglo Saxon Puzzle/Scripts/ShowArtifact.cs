using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ShowArtifact : MonoBehaviour {

    public GameController gameController;
    public bool levelEnd = false;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (gameController.score == 16)
        {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            levelEnd = true;
        }

        if (levelEnd == true)
        {
            StartCoroutine("LevelEnd");
        }
    }
           

    IEnumerator LevelEnd()
    {
        yield return new WaitForSeconds(2);
        //Application.LoadLevel("Words");
        SceneManager.LoadScene("Words", LoadSceneMode.Single);
    }
}
