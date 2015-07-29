using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class text_trigger : MonoBehaviour {
	
	public bool TextOn;
	public Text textprint;
	public string readtext;
	public Text owntext;

	
	void Start() {
		textprint = gameObject.GetComponent<Text>();
		readtext = textprint.text;
		//owntext = gameObject.GetComponent<Text>();
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		// Make text appear
		Debug.Log(textprint);
		Debug.Log(readtext);
	}
	
	void OnTriggerExit2D(Collider other) {
		// Make text disappear outside trigger
		//CanvasRenderer.Clear();
	}
	
	void OnGUI () {
	}
}
