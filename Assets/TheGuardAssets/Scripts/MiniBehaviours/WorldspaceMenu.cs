using UnityEngine;
using System.Collections;

public class WorldspaceMenu : MonoBehaviour {
	//to set private
	public Camera mainCamera;
	// Use this for initialization
	void Start () {
		mainCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (mainCamera.gameObject.transform.position);
	}
}
