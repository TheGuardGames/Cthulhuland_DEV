 using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {


	//set private
	//-references to external
	public PlayerManager playerManager;
	// Use this for initialization
	void Start () {
		playerManager = GameObject.FindGameObjectWithTag ("GameController").GetComponent<PlayerManager>();
	}
	
	// Update is called once per frame
	void Update () {
		//main action button
		if (Input.GetMouseButtonDown(0))
		{
			playerManager.PerformMainAction();
		}
	}
}
