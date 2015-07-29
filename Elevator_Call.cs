using UnityEngine;
using System.Collections;

public class Elevator_Call : MonoBehaviour {
	public bool makeOpen;
	public bool call_input;
	public bool makeClosed;
	public bool remainClosed;
	private Animator animator;
	
	void Start () {
		animator = gameObject.GetComponent<Animator>();
	}
	
	//Be sure to Credit Elevator noise
	// "Elevator_Ding", Recorded by Corsica
	// http://soundbible.com/1441-Elevator-Ding.html
	// Licensed under Sampling Plus 1.0 
	
	void Update () {
		call_input = Input.GetKey("e");
		animator.SetBool("makeOpen", makeOpen);
		animator.SetBool("makeClosed", makeClosed);
		animator.SetBool("remainClosed", remainClosed);
		if(call_input == true) {
			makeOpen = true;
			Invoke("Elevator_Sound", 0f);			
			Debug.Log("Elevator Input is working");
		}
		
		if(call_input == false) {
			makeOpen = false;
		}
		
	}
	void Elevator_Sound() {
		GetComponent<AudioSource>().Play();
		// Plays stock elevator sound 
	}
}
