using UnityEngine;
using System.Collections;

public class Elevator_Go : MonoBehaviour {
	public bool makeOpen;
	public bool call_input;
	public bool makeClosed;
	public bool remainClosed;
	//public Player player;
	private Animator animator;
	
	
	void Start () {
		//animator = gameObject.GetComponent<Animator>();
	}
	
	void Update () {
		call_input = Input.GetKey("e");		
		//animator.SetBool("makeOpen", makeOpen);
		//animator.SetBool("makeClosed", makeClosed);
		//animator.SetBool("remainClosed", remainClosed);
	
		if(call_input == true) {
			makeOpen = false;
			makeClosed = true;
			//player.Layer = 3;
		}
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		//player = other;
	}
}
