using UnityEngine;
using System.Collections;

public class trigger_test : MonoBehaviour {	
	// IMPERITIVE
	// ALWAYS SPECIFY COLLIDERS AS '2D'
	// ELSE UNITY WILL NOT RECOGNIZE!!!!!!!!
	// GRRRRRRRRRR
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		//Debug.Log(other.transform.name);
		Debug.Log("Player has entered the Trigger");
	}
	
	void OnTriggerExit2D(Collider2D other) {
		//Debug.Log(other.transform.name);
		Debug.Log("Player has exited the trigger");
	}
}
