using UnityEngine;

public class Follow : MonoBehaviour {

	public Rigidbody2D knob;
	
	// Update is called once per frame
	void Update () {

		if (knob.position.y > transform.position.y) {
		
			transform.position = new Vector3 (transform.position.x, knob.position.y, transform.position.z);
		}
	}
}
