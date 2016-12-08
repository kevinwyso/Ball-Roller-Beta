using UnityEngine;
using System.Collections;

public class endpoint : MonoBehaviour {

	//[SerializeField]
	//Fields

	//Objects
	public gameData masterObj;

	//Upon colliding with the endpoint, load the next level
	void OnTriggerEnter(Collider colInfo){
		Debug.Log ("Player in end");

		if (colInfo.tag == "Player") {
			Debug.Log ("Loading next");
			masterObj.loadNextLevel ();
		}

	}

}
