using UnityEngine;
using System.Collections;

public class MissileAction : MonoBehaviour {
	public GameObject explosion;
	void FixedUpdate() {
		GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward)* 200.0f);
	}

	void OnCollisionEnter(Collision collision) {
		ContactPoint contact = collision.contacts[0];
		GameObject exp = Instantiate(explosion, contact.point + (contact.normal*5.0f),
			Quaternion.identity) as GameObject;
		if(collision.gameObject.tag == "enemy") {
			Destroy(collision.gameObject);
		}
		Destroy(exp, 2.0f);
		Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
