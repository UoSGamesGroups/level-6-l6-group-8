using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{

    public bool correctPlace;
    public bool wrongPosition;
    public bool pieceDropped;

    public int scoreValue = 0;

    public GameController gameController;

    // Use this for initialization
    void Start()
    {
        correctPlace = false;
        wrongPosition = true;
        pieceDropped = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseUp()
    {
        if (pieceDropped == true && correctPlace == true)
        {
            gameController.AddScore(scoreValue);
            GetComponent<Score>().enabled = false;
        }
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        //This looks to see if the game object and the colider are the same name.
        if (col.gameObject.name == gameObject.name)
        {
            correctPlace = true;
            wrongPosition = false;
            pieceDropped = true;
        }

        if (col.gameObject.name != gameObject.name)
        {
            correctPlace = false;
            wrongPosition = true;
        }
    }
}
