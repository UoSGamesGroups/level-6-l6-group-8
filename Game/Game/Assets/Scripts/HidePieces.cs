using UnityEngine;
using System.Collections;

public class HidePieces : MonoBehaviour {

    public GameController gameController;

    // Use this for initialization
    void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (gameController.score == 16)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Debug.Log("Work");
        }
    }
}
