using UnityEngine;
using System.Collections;

public class InteractionManager : MonoBehaviour {

	//keep public
	public InteractionAgent currentlyPointedAgent = null;


	//set private
	public Camera uiCamera = null;


	public void Start (){	
		uiCamera = GameObject.FindGameObjectWithTag("MainCamera").transform.FindChild("UI Camera").GetComponent<Camera>();
		uiCamera.enabled = false;
	}



	//**********TO BE CALLED FROM EXTERNAL

	public void A_ShowInteractionMenu(){
		uiCamera.enabled = true;

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
		//veo dodne colisiona
		//pongo el menu ahi
		//corregir la posicion (mejor si no es necesario)
	}

}
