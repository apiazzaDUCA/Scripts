using UnityEngine;
using System.Collections;

public class Debug_Camera_mvmnt : MonoBehaviour {
	public float Speed = 10f;	// arbitrary float to use as speed multiplier 
	public float move_x = 0f; 	// movement axis of object
	public float move_y = 0f; 
	Rigidbody2D rb;
	void Start () {
	}
	
	void Update () {
		move_x = Input.GetAxis ("Horizontal");
		move_y = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2(move_x * Speed, move_y * Speed);
	
		
	}
}
