using UnityEngine;
using System.Collections;

public class trigger_test_2 : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("Player is in Trigger");
	}
}
