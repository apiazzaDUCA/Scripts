using UnityEngine;
using System.Collections;

public class honking_script : MonoBehaviour {
	public AudioClip[] clips; //array refurs to audio array
	int counter = 0;
	AudioSource audio; //refers to audio source
	
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}
	
	void OnMouseDown() {
		// All touch based scripts
		//audio.Play(); // plays audio on audio source when clicked
		audio.PlayOneShot(clips[counter]); // Play clip once
		counter++; // count # of clicks
		if(counter >= clips.Length) {
			counter = 0;
		}
			// Need collider to click
			// PlayDelay() - queue up audio 
	}
	
}
