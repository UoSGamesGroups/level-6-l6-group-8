using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2HidePieces : MonoBehaviour {

    public GameController gameController;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (gameController.score == 25)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Debug.Log("Work");
        }
    }
}
