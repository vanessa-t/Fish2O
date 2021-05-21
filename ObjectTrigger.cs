using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ObjectTrigger : MonoBehaviour 
{

	public string sceneName;

	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log ("pang");
		GameObject.Find("Feminist Fish").SendMessage("Finish");
	}

	private void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("ping");
		//GameControl.instance.FishDied ();
		//SceneManager.LoadScene (sceneName:"GameOver");
		SceneManager.LoadScene (sceneName: this.sceneName);
	}

}
