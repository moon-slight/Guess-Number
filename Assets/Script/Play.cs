using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour 
{

	public Button Exit;

	// Use this for initialization
	void Start () 
	{
		Exit.onClick.AddListener (ExitOnClick);
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void ExitOnClick()
	{
		SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
		Debug.Log ("exit\n");
	}
}
