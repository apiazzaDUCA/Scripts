using UnityEngine;
using System.Collections;

public class player_movement : MonoBehaviour {
	public float Speed = 10f;	// arbitrary float to use as speed multiplier 
	public float move_x = 0f; 	// movement axis of object
	public float move_y = 0f; 
	public float facing = 0f;
	
	
	public bool right; 			//bool to determine if player is
								//facing left or right
								// true = right
								// false = left		
	public bool Moving; 		//true if moving, false if still
	private Animator animator; //animator

	Rigidbody2D rb;

	void Start () {
		//Defines animator for later reference
		animator = gameObject.GetComponent<Animator>();
		facing = 7f;
	}
	
	void Update () {
		move_x = Input.GetAxis ("Horizontal");
		
		//Debug.Log(move_x);
		//move_x moves the object along the x axis
		// pos moves right, neg moves left
		// !!!!! Make sure move_y is commented after debugging !!!!!
		move_y = Input.GetAxis ("Vertical");
		
		// Add physics to the reading of the controller inputs
		// based on predefined variables like speed
		
		GetComponent<Rigidbody2D>().velocity = new Vector2(move_x * Speed, move_y * Speed);
		
		
		//These should affect the parameters in the animator
		// Initializes Animation parameters
		animator.SetBool("Moving", Moving);
		animator.SetBool("Right", right);
		
		//Controls state of animation
		if(move_x > 0f) {
			move_x = 1f;
			Moving = true;
			right = true;
		}
		
		else if(move_x == 0f) {
			Moving = false;
		}
		
		else if(move_x < 0f){
			move_x = -1f;
			Moving = true;
			right = false;
			facing = facing * -1f;
			//transform.localScale = new Vector3(facing, 7f, 7f);
		}
		
		//Keyboard Adjustments, Remove for better Controller Support
		if(move_x < 1f && move_x > -1f) {
			move_x = 0f;
		}
		else if(move_x > -1f && move_x < 0f) {
			move_x = 0f;
		}
		
	}
}
