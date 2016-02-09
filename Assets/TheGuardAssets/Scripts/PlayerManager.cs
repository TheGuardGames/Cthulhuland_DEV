using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {


	//set private
	///references to external
	public GameManager gameManager;
	public InteractionManager interactionManager;
	// Use this for initialization
	void Start () {
		gameManager = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameManager>();
		interactionManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<InteractionManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	//playertriggered actions 

	//mouse left button
	public void  PerformMainAction (){

		//GameManager.GameStatus.Exploring
		switch (gameManager.gameStatus){
				
			case GameManager.GameStatus.Exploring:
				//if object pointed != then begin interaction
			if (interactionManager.A_IsItemPointed()){
				interactionManager.A_ShowInteractionMenu ();
				Debug.Log ("item pointed, call show menu");
			}
			else
				Debug.Log  ("item not pointed. do nothing");
			

					


				Debug.Log  ("exploring");
				break;

			case GameManager.GameStatus.Inventory:
				Debug.Log  ("inventory");
				break;
		}



	}


}
