using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTeleportHandler : MonoBehaviour {

	public List<Vector3> locations = new List<Vector3>();

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}


	public void TeleportPlayerTo(int locationIndex)
	{
		transform.position = locations[locationIndex];
	}
}
