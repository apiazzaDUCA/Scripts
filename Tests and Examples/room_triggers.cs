using UnityEngine;
using System.Collections;

public class room_triggers : MonoBehaviour {
	void OnTriggerEnter2D(Collider2D other) {
		//print name of room to console
		Debug.Log(other.transform.name);
	}
}
