using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class AchievmentManager : MonoBehaviour 
{

	public GameObject achievmentPrefab;

	public Sprite[] sprites;

	private AchievementButton activeButton;
	public ScrollRect scrollRect;

	public GameObject achievmentMenu;

	public GameObject visualAchievment;

	public Dictionary <string, Achievment> achievments = new Dictionary <string, Achievment> ();

	void Start () 
	{
		activeButton = GameObject.Find ("All_Btn").GetComponent<AchievementButton> ();
		CreateAchievment ("General", "Artifact - Shield", "Complete the WatchTower", 10,0);
	

		CreateAchievment ("Saxon", "Artifact - Cauldron", "Complete the Hut", 10,1);
		CreateAchievment ("Saxon", "Artifact - Crown", "Complete the Castle", 10,3);
		CreateAchievment ("Saxon", "Artifact - Cross", "Complete the Church", 10,1);
		CreateAchievment ("Saxon", "Artifact - Plough", "Complete the Farm", 10,1);
		CreateAchievment ("Saxon", "Artifact - Offa Coin", "Complete the Market", 10,1);
		CreateAchievment ("Saxon", "Artifact - Shield ", "Complete the WatchTower", 10,1);
		CreateAchievment ("Saxon", "Artifact - Norman Shiled", "Complete the BattleField", 10,1);
		CreateAchievment ("Saxon", "The Saxons", "Complete Saxon World", 20,1);



		foreach (GameObject achievmentList in GameObject.FindGameObjectsWithTag("AchievmentList"))
		{
			achievmentList.SetActive (false);
		}

		activeButton.Click ();

		achievmentMenu.SetActive (false);

	}

	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.I)) 
		{
			achievmentMenu.SetActive (!achievmentMenu.activeSelf);
		}

		if (Input.GetKeyDown (KeyCode.W)) 
		{
			EarnAchievment ("Artifact - Shield");
		}

        if (Input.GetKeyDown(KeyCode.Q))
        {
            EarnAchievment("Artifact - Crown");
        }
    }
		
	public void EarnAchievment(string title)
	{
		if (achievments[title].EarnAchievment ()) 
		{
			GameObject achievment = (GameObject)Instantiate(visualAchievment);
			SetAchievmentInfo ("Canvas_E", achievment, title);

			StartCoroutine (HideAchievment (achievment));
		}
	}

	public IEnumerator HideAchievment(GameObject achievment)
	{
		yield return new WaitForSeconds (3);
		Destroy (achievment);
	}

	public void CreateAchievment (string parent, string title,string description, int points, int spriteIndex)

		{
			GameObject achievment = (GameObject)Instantiate(achievmentPrefab);

		Achievment newAchievment = new Achievment (name, description, points, spriteIndex, achievment);
		achievments.Add (title, newAchievment);

		SetAchievmentInfo (parent, achievment,title);
		}

	public void SetAchievmentInfo(string parent, GameObject achievment, string title)
	{
		achievment.transform.SetParent (GameObject.Find (parent).transform);
		achievment.transform.localScale = new Vector3 (1, 1, 1);
		achievment.transform.GetChild (0).GetComponent<Text> ().text = title;
		achievment.transform.GetChild (1).GetComponent<Text> ().text = achievments[title].Description;
		achievment.transform.GetChild (2).GetComponent<Text> ().text = achievments[title].Points.ToString();
		achievment.transform.GetChild (3).GetComponent<Image> ().sprite = sprites [achievments [title].SpriteIndex];

	}

	public void ChangeCategory(GameObject button)
	{
		AchievementButton achievmentButton = button.GetComponent<AchievementButton> ();

		scrollRect.content = achievmentButton.achievmentList.GetComponent<RectTransform> ();

		achievmentButton.Click ();
		activeButton.Click ();
		activeButton = achievmentButton;

	}
}
