using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {
	public float timeAliveLimit;
	public float speed;

	private float startTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
		rigidbody2D.AddForce(transform.up * speed);
	}
	
	// Update is called once per frame
	void Update () {
		if(timeAliveLimit <= Time.time - startTime)
			Destroy(this.gameObject);
	}

	void OnCollisionEnter2D(Collision2D theCollision) {
		if(theCollision.gameObject.tag != "Player")
			Destroy (this.gameObject);
	}
}
