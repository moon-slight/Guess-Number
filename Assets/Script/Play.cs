using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour 
{

	public Button Exit, Yes, No;
	public GameObject ExitPanel;

	// Use this for initialization
	void Start () 
	{
		ExitPanel.SetActive (false);
		Exit.onClick.AddListener (ExitOnClick);
		Yes.onClick.AddListener (YesOnClick);
		No.onClick.AddListener (NoOnClick);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
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
