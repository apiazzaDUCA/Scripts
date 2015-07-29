using UnityEngine;
using System.Collections;

public class ai_mvmnt : MonoBehaviour {
	public float Speed = 10f;	// arbitrary float to use as speed multiplier 
	public float move_x = 0f; 	// movement axis of object
	public float move_y = 0f; 
	public float facing = 0f;			
	public bool Moving; 		//true if moving, false if still

	Rigidbody2D rb;

	void Start () {
		move_x = 0.5f;
		facing = 1f;
	}
	
	void Update () {

		GetComponent<Rigidbody2D>().velocity = new Vector2(move_x * Speed, move_y * Speed);
		//animator.SetBool("Moving", Moving);
		}
		
	void OnTriggerExit2D(Collider2D other) {
		move_x = move_x * -1f;	// Object gets to end of patrol trigger
		facing = facing * -1f;	// then inverts sprite and direction
		transform.localScale = new Vector3(facing, 1, 1); 
	}	
}
