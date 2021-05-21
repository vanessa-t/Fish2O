using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreEndScreen : MonoBehaviour {

	
	public Text scoreText;
	public Text highScoreText;

	// Use this for initialization
	void Start () 
	{
		highScoreText.text = ((float)PlayerPrefs.GetFloat ("Highscore")).ToString("f2");
	}
	
	// Update is called once per frame
	void Update () 
	{
		scoreText.text = (PlayerPrefs.GetString ("CurrentScore"));
	}
}
