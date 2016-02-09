using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public enum GameStatus{Exploring, Inventory,ItemTargeted, InteractingWithItem}

	//keep public
	public GameStatus gameStatus = GameStatus.Exploring;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
