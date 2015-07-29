using UnityEngine;
using System.Collections;

public class stayalive : MonoBehaviour {
	// This prevents an object from being destroyed
	// put on sound obj so sound persists
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
