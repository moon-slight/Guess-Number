using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour 
{

	public GameObject ExitPanel;
	public InputField Input;
	private string Answer = "";
	private string Hint;
	protected string Guess;

	// Use this for initialization
	void Start () 
	{
		//set button state
		ExitPanel.SetActive (false);

		int RandNum;
		while (Answer.Length < 4) 
		{
			RandNum = Random.Range (0, 9);
			if (CheckIsRepeat (RandNum, Answer.Length)) 
				Answer = Answer + RandNum.ToString ();
		}
		Debug.Log (Answer);
	}
	
	// Update is called once per frame
	void Update () 
	{
		TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NumberPad, true, false, true);
		
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

	public void ExitOnClick()
	{
		ExitPanel.SetActive (true);
		Debug.Log ("exit\n");
	}

	public void YesOnClick()
	{
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
		Debug.Log ("yes\n");
	}

	public void NoOnClick()
	{
		ExitPanel.SetActive (false);
		Debug.Log ("no\n");
	}
}
