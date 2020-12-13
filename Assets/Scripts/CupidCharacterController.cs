using UnityEngine;
using System.Collections;

public class CupidCharacterController : MonoBehaviour {

    public float speed = 50.0F;
	public float playerNumber;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<BowController>().Init(playerNumber);
	}
	
	void Move(Vector3 direction) {
        transform.Translate(direction.x * speed, 0, direction.z * speed, Space.World);
	}

	void Face(Vector3 direction) {
		if(direction == new Vector3(0,0,0)){
			return;
		}
		Quaternion rotation = Quaternion.LookRotation(direction);
		transform.rotation = rotation;
	}

	Vector3 GetInputs () {
        float translationZ = Input.GetAxis("Vertical" + playerNumber);
		float directionZ = translationZ/Mathf.Abs(translationZ);
		if (float.IsNaN(directionZ)) {
			directionZ = 0;
		}
        directionZ *= Time.deltaTime;
        float translationX = Input.GetAxis("Horizontal" + playerNumber);
		float directionX = translationX/Mathf.Abs(translationX);
		if (float.IsNaN(directionX)) {
			directionX = 0;
		}
        directionX *= Time.deltaTime;
		return new Vector3(directionX, 0f, directionZ);
	}

	// Update is called once per frame
	void Update () {
		Vector3 direction = GetInputs();
		Move(direction);
		Face(direction);
	}
}
