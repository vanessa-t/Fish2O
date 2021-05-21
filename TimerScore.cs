using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScore: MonoBehaviour {

	private float score = 0.000f;

	public Text scoreText;
	private bool finished = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		score += Time.deltaTime;
		scoreText.text = ((float)score).ToString("f2");
	}

	public void Finish()
	{
		finished = true;
		//timerText.color = Color.yellow;
		PlayerPrefs.SetString ("CurrentScore", scoreText.text);
		if(PlayerPrefs.GetFloat ("Highscore") < score)
			PlayerPrefs.SetFloat ("Highscore", score);
		//PlayerPrefs.SetFloat ("Highscore", score);
	}
}
