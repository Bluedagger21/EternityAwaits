using UnityEngine;
using System.Collections;

public class AsteroidBehavior : MonoBehaviour {
	public int health;

	// Use this for initialization
	void Start () {
		int angle = Random.Range (0, 360);
		transform.Rotate (0, 0, angle);
	}

	// Update is called once per frame
	void Update () {
	
	}

	void ApplyDamage(int damage) {
		health -= damage;
		if(health == 0) {
			Destroy(this.gameObject);
		}
	}
}
