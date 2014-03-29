using UnityEngine;
using System.Collections;

public class SystemGenerationBehavior : MonoBehaviour {
	public float max = 100.0f;
	public float min = 0.0f;
	public int maxAsteroids = 30;
	public int maxPlanets = 3;

	// Use this for initialization
	void Start () {
		GenerateSystem ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void GenerateSystem() {
		for(int i = 0; i < maxAsteroids; i++){
			Vector3 pos = new Vector3(Random.Range(-max,max), Random.Range(-max,max), 0);
			Instantiate(Resources.Load<GameObject>("Sprites/Prefabs/meteorBrown_big1"), pos, Quaternion.identity);
		}
		for(int i = 0; i < maxPlanets; i++){
			Vector3 pos = new Vector3(Random.Range(-max,max)/2, Random.Range(-max,max)/2, 0);
			Instantiate(Resources.Load<GameObject>("Sprites/Prefabs/Planets/p1"), pos, Quaternion.identity);
		}
	}
}
