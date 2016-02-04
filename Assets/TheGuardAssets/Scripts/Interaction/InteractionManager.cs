using UnityEngine;
using System.Collections;

public class InteractionManager : MonoBehaviour {

	//keep public
	public InteractionAgent currentlyPointedAgent = null;


	//set private
	public Camera uiCamera = null;
	public GameObject interactionMenuGO = null;

	public void Start (){	
		uiCamera = GameObject.FindGameObjectWithTag("MainCamera").transform.FindChild("UI Camera").GetComponent<Camera>();
		interactionMenuGO = GameObject.FindGameObjectWithTag("WSCanvasHolder").transform.FindChild("CanvasPROTOTYPE1").gameObject;
		uiCamera.enabled = false;
	}



	//**********TO BE CALLED FROM EXTERNAL

	public void A_ShowInteractionMenu(){
		uiCamera.enabled = true;
		PutMenuInPlace();
		//

	}


	//public to be called from other scripts
	public bool A_IsItemPointed(){
		if (currentlyPointedAgent != null)
			return true;

		return false;
	}


	//*************iINTERNAL SUPPORT
	private void PutMenuInPlace (){
		//trazo un rayo desd ela uiCamera
		RaycastHit hit;

		Debug.DrawRay (uiCamera.transform.position, uiCamera.transform.forward*100, Color.red,20);

		Physics.Raycast (uiCamera.transform.position, uiCamera.transform.forward, out hit, 100);

		if (hit.transform != null && hit.transform.tag == "InteractiveByRay"){
			Vector3 newPosition = uiCamera.gameObject.transform.forward * 5;
			interactionMenuGO.transform.position = newPosition;
			Debug.Log (newPosition );
			//Debug.Log (uiCamera.transform.rotation);
			Debug.Log ("####");
		} else{
				//Debug.Log ("CAN'T put menu");  

		}
		//veo dodne colisiona
		//pongo el menu ahi
		//corregir la posicion (mejor si no es necesario)
	}

}
