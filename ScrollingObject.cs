using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour {

	public float Speed = 1;
	public List<SpriteRenderer> sprites = new List<SpriteRenderer>();


	private Direction Dir = Direction.Down;
	private float heightCamera;
	private float widthCamera;

	private Vector3 PositionCam;
	private Camera cam;

	private void Awake()
	{
		cam = Camera.main;
		heightCamera = 2f * cam.orthographicSize;
		widthCamera = heightCamera * cam.aspect;
	}

	void Update ()
	{
		foreach (var item in sprites)
		{
			if(Dir == Direction.Down)
			{
				if (item.transform.position.y + item.bounds.size.y / 2 < cam.transform.position.y - heightCamera / 2)
				{
					SpriteRenderer sprite = sprites[0];
					foreach (var i in sprites)
					{
						if (i.transform.position.y > sprite.transform.position.y)
							sprite = i;
					}
			}


			if (Dir == Direction.Down)
				item.transform.Translate(new Vector2(0,Time.deltaTime * Speed * -1));

		}

	}
}

public enum Direction
	{
		Down
	}
}
