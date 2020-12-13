using UnityEngine;
using System.Collections;

public class LoverController : MonoBehaviour {

	public float speed = 5.0F;

	// Use this for initialization
	void Start () {
		Invoke ("Turn", 1f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.localPosition += transform.forward * Time.deltaTime * speed;
	}

	void Turn () {
		transform.Rotate(new Vector3(0f, Random.Range(0, 180), 0f));
		Invoke ("Turn", 1f);
	}
}
