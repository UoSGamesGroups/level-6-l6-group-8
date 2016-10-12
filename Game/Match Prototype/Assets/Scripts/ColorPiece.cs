using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ColorPiece : MonoBehaviour {

	public enum ColourType
	{
		BROWN,
		PURPLE,
		RED,
		BLUE,
		GREEN,
		PINK,
		ANY,
		COUNT,
	};

	[System.Serializable]
	public struct ColourSprite
	{
		public ColourType colour;
		public Sprite sprite;
	};

	public ColourSprite[] colourSprites;

	private ColourType colour;
	 
	public ColourType Colour 
	{
		get { return colour; }
		set { SetColour (value); }
	}

	public int NumColours
	{ 
		get { return colourSprites.Length; }
	}

	private SpriteRenderer sprite;
	private Dictionary<ColourType, Sprite> colourSpriteDict;

	void Awake()
	{
		sprite = transform.Find ("piece").GetComponent<SpriteRenderer> ();

		colourSpriteDict = new Dictionary<ColourType, Sprite> ();

		for (int i = 0; i < colourSprites.Length; i++) {
			if (!colourSpriteDict.ContainsKey (colourSprites [i].colour)) {
				colourSpriteDict.Add (colourSprites [i].colour, colourSprites [i].sprite);
			}
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetColour(ColourType newColour)
	{
		colour = newColour;

		if (colourSpriteDict.ContainsKey (newColour)) {
			sprite.sprite = colourSpriteDict [newColour];
		}
	}
}
