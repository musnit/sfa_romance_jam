using UnityEngine;
using System.Collections;

public class LoverSpawner : MonoBehaviour {

	public GameObject lover;

	// Use this for initialization
	void Start () {
		Spawn();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Spawn() {
		Instantiate(lover, transform.position, transform.localRotation);
		Invoke ("Spawn", 1f);
	}
}
