using UnityEngine;
using System.Collections;

public class camera_transition_2 : MonoBehaviour {
	public Camera camera;
	public float camera_x;
	public float camera_y;
	public float camera_z;
	public float camera_x_new;
	public float camera_y_new;
	public float camera_currentpos;
	public bool playercheck;

	
	void Start() {
		
		//Debug.Log("Tag = " + camera.transform.localScale);	
		camera = gameObject.GetComponentInParent<Camera>();
		camera_x = camera.transform.position.x;
		camera_y = camera.transform.position.y;
		camera_z = camera.transform.position.z;
		//Debug.Log("Before = " + camera.transform.position.x);
		//Debug.Log("Before = " + camera.transform.position.y);
	}
		

	void Update() {
		// Spartan Camera Design,
		// make sure all rooms are equally spaced
		// if player hits horizontal trigger, move the camera one block left
		// if they hit the elevator, go down certain coordinates
		// add to elevator script along with player teleport
		//gets current position of the camera
		// do i need a function to change position of camera?
	}

	void OnTriggerEnter2D(Collider2D other) {
		if(other.tag == "Player") { //only player can transition camera
			//Debug.Log("Hello player");
			playercheck = true;
			camera_x_new = camera_x + 2170.5f;
			camera_y_new = camera_y + 0;
			//WaitForSeconds(5f);
			camera.transform.Translate(new Vector3(camera_x_new * Time.deltaTime * 10, camera_y_new, camera_z));
			//Debug.Log("After = " + camera.transform.position.x);
			//Debug.Log("y pos = " + camera.transform.position.y);
			// only need to change 'x' b/c room is nextdoor
		}
	}
}
