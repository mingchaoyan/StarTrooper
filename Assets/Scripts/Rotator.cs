using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public float rotateSpeed = 10.0f;

	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.forward, rotateSpeed* Time.deltaTime);	
	}
}
