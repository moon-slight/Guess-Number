using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour 
{

	public GameObject ExitPanel;
	public GameObject WarningPanel;
	public GameObject WinPanel;
	public InputField Input;
	public Text ShowHint = null;

	private string Answer = "";
	private string Hint = "";
	protected string Guess;

	// Use this for initialization
	void Start () 
	{
		//set panel state
		ExitPanel.SetActive (false);
		WarningPanel.SetActive (false);
		WinPanel.SetActive (false);

		int RandNum;
		while (Answer.Length < 4) 
		{
			RandNum = Random.Range (0, 9);

			if (CheckIsRepeat (RandNum, Answer.Length, Answer))
				Answer = Answer + RandNum.ToString ();
		}
		Debug.Log (Answer);
	}
	
	// Update is called once per frame
	void Update () 
	{
		TouchScreenKeyboard.Open("", TouchScreenKeyboardType.NumberPad, true, false, true);
		
	}

	bool CheckIsRepeat(int checknum, int length, string targetnum)
	{
		for(int i = 0; i < length; i++)
		{
			if ( checknum == (System.Convert.ToInt32(targetnum[i] - 48)) ) //change targetnum from string to int
				return false;
		}
		return true;
	}

	public void AnalyseHint(string GuessNum, string Answer) //show player hint (how many A and B)
	{
		int A = 0, B = 0;
		for (int i = 0; i < 4; i++)
		{
			for (int k = 0; k < 4; k++)
			{
				if (GuessNum [i] == Answer [k] && i == k)
					A++;
				else if (GuessNum [i] == Answer [k])
					B++;
			}
		}
		Hint = Hint + GuessNum + "  " + A + "A" + B + "B\n";
		ShowHint.text = Hint;

		if (A == 4)
			WinPanel.SetActive (true);
	}

	// below are different actions when click different buttons
	public void InputOnClick()
	{
		bool GoOn = true;
		for (int i = 0; i < 4 && GoOn; i++)
		{
			for (int k = i + 1; k < 4; k++)
			{
				if ( ((System.Convert.ToInt32 (Input.text [i]) - 48) == (System.Convert.ToInt32 (Input.text[k]) - 48)) )
				{
					Debug.Log ("wrong");
					WarningPanel.SetActive (true);
					GoOn = false;
					break;
				}
			}
		}
		if (GoOn)
		{
			Debug.Log ("right");
			AnalyseHint (Input.text, Answer);
		}
	}

	public void CloseWarningPanle()
	{
		WarningPanel.SetActive (false);
		Debug.Log ("ok\n");
	}

	public void ShowExitPanel()
	{
		ExitPanel.SetActive (true);
		Debug.Log ("exit\n");
	}

	public void GoToMainMenu()
	{
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
		Debug.Log ("yes\n");
	}

	public void CloseExitPanel()
	{
		ExitPanel.SetActive (false);
		Debug.Log ("no\n");
	}

	public void Again()
	{
		SceneManager.LoadScene ("Play", LoadSceneMode.Single);
	}
}
