using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {


	//set private
	///references to external
	public GameManager gameManager;

	// Use this for initialization
	void Start () {
		gameManager = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameManager>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	//playertriggered actions 

	//mouse left button
	public void  PerformMainAction (){

		//GameManager.GameStatus.Exploring
		switch (gameManager.gameStatus){
			//if object pointed != then begin interaction
			case GameManager.GameStatus.Exploring:
			Debug.Log  ("exploring");
			break;

		case GameManager.GameStatus.Inventory:
			Debug.Log  ("inventory");
			break;
		}



	}


}
