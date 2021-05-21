using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour 
{

	private bool isDead = false;
	private Rigidbody2D rb2d;


	void Update () 
	{
		if (isDead == false)
		{
			
		float moveHorizontal;
		float pos = 2.46f;
		float move = 0.01f;

		//phone
		//moveHorizontal = Input.acceleration.x;
		//computer
		moveHorizontal = Input.GetAxis("Horizontal");

		//if fish at the left edge, fish can't move left
		if (transform.position.x < -(pos)) {
			moveHorizontal = (move);
		}

		//if fish at the right edge, fish can't move right
		if (transform.position.x > (pos)) {
			moveHorizontal = -(move);
		}

		transform.Translate(moveHorizontal / 4, 0, 0);

		//end if
		//Debug.Log(transform.position.x);
		}
	}



/*
using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour 
{
	void Update () 
	{
		float moveHorizontal;
		//phone
		//moveHorizontal = Input.acceleration.x;
		//computer
		moveHorizontal = Input.GetAxis("Horizontal");

		//if not at the edge yet
		transform.Translate(moveHorizontal, 0, 0);
		//end if
		//Debug.Log(moveHorizontal);
	}
}
*/

	void OnCollistionEnter2D ()
	{
		isDead = true;
		GameControl.instance.FishDied ();
	}
}
