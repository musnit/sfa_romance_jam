using UnityEngine;
using System.Collections;

public class ArrowController : MonoBehaviour {

	public float arrowSpeed = 200f;
	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.AddForce(transform.forward * arrowSpeed);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void FixedUpdate () {
	}

}
