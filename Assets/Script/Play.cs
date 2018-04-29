using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour 
{

	public Button Exit, Yes, No;
	public GameObject ExitPanel;
	private string Answer = "";
	private string Hint;
	protected string Guess;

	// Use this for initialization
	void Start () 
	{
		//set button state
		ExitPanel.SetActive (false);
		Exit.onClick.AddListener (ExitOnClick);
		Yes.onClick.AddListener (YesOnClick);
		No.onClick.AddListener (NoOnClick);

		int i = 0, RandNum;
		while (i < 4) 
		{
			RandNum = Random.Range (0, 9);
			if (CheckIsRepeat (RandNum, Answer.Length)) 
			{
				Answer = Answer + RandNum.ToString ();
				i++;
			}
		}
		Debug.Log (Answer);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	bool CheckIsRepeat(int checknum, int length)
	{
		for(int i = 0; i < length; i++)
		{
			if (checknum == Answer [i])
				return false;
		}
		return true;
	}

	void ExitOnClick()
	{
		ExitPanel.SetActive (true);
		Debug.Log ("exit\n");
	}

	void YesOnClick()
	{
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
		Debug.Log ("yes\n");
	}

	void NoOnClick()
	{
		ExitPanel.SetActive (false);
		Debug.Log ("no\n");
	}
}
