using UnityEngine;
using System.Collections;

public class InteractorTool : MonoBehaviour {
	//keep public
	public float interactionDistance = 0.5f;
	public float triggerTime = 3f;
	
	//set private
	///for inner processes
	public float triggerTimer = 0;
	public InteractionAgent currentAgent;
	public InteractionAgent lastSelected;
	public GameObject player;
	public Camera playerCamera;
	//public WaypointManager waypointManager;
	//public Animator animator;
	//public WaypointBehaviour currentWaypoint;
	/// references to external
	public InteractionManager interactionManager;

	// Use this for initialization
	void Start () {
		//initialize inner processes vars
		player = GameObject.FindGameObjectWithTag ("MainCamera").gameObject;
		playerCamera = player.GetComponent<Camera>();
		//waypointManager = GameObject.FindGameObjectWithTag ("WaypointHelpers").GetComponent<WaypointManager>();
		//animator = GetComponent<Animator>();
		interactionManager = GameObject.FindGameObjectWithTag ("GameController").GetComponent<InteractionManager>();
		Debug.Log (interactionManager.name);
	}
	
	// Update is called once per frame
	void Update () {
		
		//CheckForActivation();
		RaycastHit hit;
		Debug.DrawRay (playerCamera.transform.position, playerCamera.transform.forward*interactionDistance, Color.cyan);
		
		Physics.Raycast (playerCamera.transform.position, playerCamera.transform.forward, out hit, interactionDistance);
		
		if (hit.transform != null && hit.transform.tag == "InteractiveByRay"){
			interactionManager.currentlyPointedAgent = hit.transform.GetComponent<InteractionAgent>();
			//Debug.Log (hit.transform.name);
			//currentAgent = hit.transform.GetComponent<InteractionAgent>();  //esto sobra, ahora esta en interaction manager

		} else{
			interactionManager.currentlyPointedAgent = null;
			//currentAgent = null;//esto sobra, ahora esta en interaction manager
		}
		
		

		
	}
	
	


	//public methods
	public bool ItemTargeted(){
		if (currentAgent == null)
			return false;
		return true;
	}
	


	
	

}
