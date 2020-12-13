using UnityEngine;
using System.Collections;

public class BowController : MonoBehaviour {

	private float playerNumber;
	public GameObject arrow;

	private bool fired = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if( !fired && Input.GetButton("Fire" + playerNumber) ) {
			Instantiate(arrow, transform.position + transform.forward, transform.localRotation);
			fired = true;
		}
		if( !Input.GetButton("Fire" + playerNumber) ) {
			fired = false;
		}
	}

	public void Init(float playerNumber) {
		this.playerNumber = playerNumber;
	}
}
