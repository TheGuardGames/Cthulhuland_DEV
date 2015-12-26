using UnityEngine;
using System.Collections;

public class InteractionManager : MonoBehaviour {

	//keep public
	public InteractionAgent currentlyPointedAgent = null;






	//public to be called from other scripts
	public bool A_IsItemPointed(){
		if (currentlyPointedAgent != null)
			return true;

		return false;
	}

}
