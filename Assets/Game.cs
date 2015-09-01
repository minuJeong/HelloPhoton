using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Game : Photon.MonoBehaviour
{

	public Text outputText;


	void Start ()
	{
		outputText.text = "Disconnected";
	}

	public void OnClickConnectButton ()
	{
		outputText.text = "Connecting..";
		
		PhotonNetwork.ConnectUsingSettings ("v4.2");
	}


	public void OnConnectedToMaster ()
	{
		outputText.text = "Connected to master.";

		PhotonNetwork.JoinRandomRoom ();
	}

	public void OnPhotonRandomJoinFailed()
	{
		outputText.text = "Join Failed. Creating Room..";

		PhotonNetwork.CreateRoom (null);
	}

	public void OnCreateRoom ()
	{
		outputText.text = "Joined room.";
		
		GoGame ();
	}


	public void OnJoinedRoom ()
	{
		outputText.text = "Joined room.";

		GoGame ();
	}

	private void GoGame ()
	{
		Application.LoadLevel ("InGame");
	}
}
