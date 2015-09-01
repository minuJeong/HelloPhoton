using UnityEngine;
using System.Collections;

public class Control : Photon.MonoBehaviour
{
	public float SPEED = 2.5F;

	void Start ()
	{
		DontDestroyOnLoad (gameObject);
	}

	// Update is called once per frame
	void Update ()
	{
		if (! photonView.isMine)
		{
			return;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (0, - SPEED, 0);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Translate (0, 0, SPEED * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (0, SPEED, 0);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Translate (0, 0, - SPEED * Time.deltaTime);
		}
	}
}
