using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

    public int score;
    public Text scoreText;

    
  

	// Use this for initialization
	void Start () {

        score = 0;
        UpdateScore ();	
	}
	
	// Update is called once per frame
	void Update () {
	}

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore ()
    {
        scoreText.text = "Correct Pieces: " + score;
    }
}
