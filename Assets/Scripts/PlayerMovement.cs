using UnityEngine;
using System.Collections;
using EyeTribe.ClientSdk;

public class PlayerMovement : MonoBehaviour {

	public float maxSpeed = 10f;
	public float rotationSpeed = 180f; // we are using degrees

	float spaceBoundaryY = 50;
	float spaceBoundaryX = 50;
	float shipHitbox = 0.5f;

	private GazePoint gp;

	// Use this for initialization
	void Start () {
		this.gp = new GazePoint();
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 gazePosition = gp.getPosition();

		//rotate to look at the player
		transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(gazePosition - transform.position), rotationSpeed * Time.deltaTime);

		//move towards the player
		transform.position += transform.forward * Time.deltaTime * maxSpeed;


//		// Rotating
//		Quaternion rotation = transform.rotation;
//		float z = rotation.eulerAngles.z;
//		z -= Input.GetAxis ("Horizontal") * rotationSpeed * Time.deltaTime;
//		rotation = Quaternion.Euler (0, 0, z);
//		transform.rotation = rotation;
//
//
//
//		// Moving
//		Vector3 pos = transform.position;
//		Vector3 velocity = new Vector3(0, Input.GetAxis("Vertical") * maxSpeed * Time.deltaTime, 0);
//
//
//		pos += rotation * velocity;
//
//		// Movement restriction
//		if (pos.y + shipHitbox > spaceBoundaryY) {
//			pos.y = spaceBoundaryY - shipHitbox;
//		}
//		if (pos.y - shipHitbox < -spaceBoundaryY) {
//			pos.y = -spaceBoundaryY + shipHitbox;
//		}
//		if (pos.x + shipHitbox > spaceBoundaryX) {
//			pos.x = spaceBoundaryX - shipHitbox;
//		}
//		if (pos.x - shipHitbox < -spaceBoundaryX) {
//			pos.x = -spaceBoundaryX + shipHitbox;
//		}
//
//		transform.position = pos;


	}
}
