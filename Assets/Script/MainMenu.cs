using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{

	public Button Play, Help, Exit, Back;
	public GameObject HelpPanel;

	// Use this for initialization
	void Start () 
	{
		HelpPanel.SetActive (false);
		Play.onClick.AddListener (PlayOnClick);
		Help.onClick.AddListener (HelpOnClick);
		Exit.onClick.AddListener (ExitOnClick);
		Back.onClick.AddListener (BackOnClick);
	}

	void PlayOnClick()
	{
		SceneManager.LoadScene ("Play", LoadSceneMode.Single);
		Debug.Log ("play\n");
	}

	void HelpOnClick()
	{
		HelpPanel.SetActive (true);
		Debug.Log ("help\n");
	}

	void ExitOnClick()
	{
		Application.Quit ();
		Debug.Log ("exit\n");
	}

	void BackOnClick()
	{
		HelpPanel.SetActive (false);
		Debug.Log ("back\n");
	}
}
