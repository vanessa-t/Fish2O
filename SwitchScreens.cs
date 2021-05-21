using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwitchScreens : MonoBehaviour 
{
	public string sceneName;

	public void startGame ()
		{
			SceneManager.LoadScene (sceneName: this.sceneName);
		}

}

