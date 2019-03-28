using UnityEngine;

public class Rotation : MonoBehaviour {

	public float rotator = 100f;

	// Update is called once per frame
	void Update () {
		
		transform.Rotate (0f, 0f, rotator * Time.deltaTime);
	}
}