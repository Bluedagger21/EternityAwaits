using UnityEngine;
using System.Collections;

public class ShootBehavior : MonoBehaviour {
	public GameObject projectile;
	public float fireRate = 1.0F;

	private float nextFire = 0.0F;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("space") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			GameObject clone = Instantiate (projectile, transform.position, transform.rotation) as GameObject;
		}
	}
}
