using UnityEngine;
using System.Collections;

public class Shek : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("Die", 1f);		
		//Debug.Log(Static.test_1); //calls static variable already defined
		//Debug.Log(Static.get().test_1);
		
	}
	
	// Update is called once per frame
	void Update () {
		//Destroy(gameObject, 1f); // destroys gameObject in one second

	}
	
	void Die() {
		GetComponent<AudioSource>().Play(); // start audio source then die
		Destroy(gameObject, 1f);
	}
}
