using UnityEngine;
using System.Collections;

public class ProjectileScript : MonoBehaviour {
	public float speed = .01f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.AddForce(new Vector2(0f, speed));

		if (!renderer.isVisible) {
			Destroy(gameObject);
		}
	}
}
