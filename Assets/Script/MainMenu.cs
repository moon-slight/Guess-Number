using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
	public GameObject HelpPanel;

	// Use this for initialization
	void Start () 
	{
		HelpPanel.SetActive (false);
	}

	public void GoToPlay()
	{
		SceneManager.LoadScene ("Play", LoadSceneMode.Single);
		Debug.Log ("play\n");
	}

	public void ShowHelpPanel()
	{
		HelpPanel.SetActive (true);
		Debug.Log ("help\n");
	}

	public void ExitGame()
	{
		Application.Quit ();
		Debug.Log ("exit\n");
	}

	public void CloseHelpPanel()
	{
		HelpPanel.SetActive (false);
		Debug.Log ("back\n");
	}
}
