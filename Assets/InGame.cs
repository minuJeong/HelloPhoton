using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InGame : MonoBehaviour
{
	public Text outputText;

	// Use this for initialization
	void Start ()
	{
		if (! PhotonNetwork.connected)
		{
			Application.LoadLevel ("Startup");
			return;
		}

		outputText.text = "Successfully Joined Room";

		GameObject PlayerPawn;

		PlayerPawn = PhotonNetwork.Instantiate ("SyncronizedPlayer", Vector3.zero, Quaternion.identity, 0);

		Camera.main.transform.SetParent (PlayerPawn.transform);
	}
}
