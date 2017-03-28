using UnityEngine;
using System.Collections;

public class Achievment 
{

	private string name;
	public string Name
	{
		get { return name;}
		set { name = value;}
	}

	private string description;
	public string Description
	{
		get { return description;}
		set { description = value;}
	}

	private bool unlocked;
	public bool Unlocked
	{
		get { return unlocked;}
		set { unlocked = value;}
	}

	private int points;
	public int Points
	{
		get { return points;}
		set { points = value; }
	}

	private int spriteIndex;
	public int SpriteIndex
	{
		get { return spriteIndex;}
		set { spriteIndex = value;}
	}


	private GameObject achievmentRef;


	public Achievment(string name, string description, int points, int spriteIndex, GameObject achievmentRef)
	{
		this.name = name;
		this.description = description;
		this.unlocked = false;
		this.points = points;
		this.spriteIndex = spriteIndex;
		this.achievmentRef = achievmentRef;
	}

	public bool EarnAchievment()
	{
		if (!unlocked) 
		{
			unlocked = true;
			return true;
		}
		return false;
	}
}
