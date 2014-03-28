using UnityEngine;
using System.Collections;

public class ShipBehavior : MonoBehaviour {
	public float thrust;
	public float strafeThrust;
	public float maxThrust;
	public float yaw;
	public float maxYaw;

	private GameObject [] guns;
	private Vector3 cursorPos;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		cursorPos.z = transform.position.z;
		transform.rotation = Quaternion.LookRotation (Vector3.forward, cursorPos - transform.position);

		rigidbody2D.AddForce(transform.up * thrust * Input.GetAxis("Thrust"));
		rigidbody2D.AddForce(transform.right * strafeThrust * Input.GetAxis ("Horizontal"));

		rigidbody2D.velocity = Vector2.ClampMagnitude(rigidbody2D.velocity, maxThrust);
	}
}
