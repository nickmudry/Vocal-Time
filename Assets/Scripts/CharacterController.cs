using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour {
	public float yLock;
	GameObject projectileSpawner;
	public GameObject projectile;
	// Use this for initialization
	void Start () {
		projectileSpawner = GameObject.Find ("ProjectileSpawn");
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

		gameObject.transform.position = new Vector3(mousePosition.x, yLock, 4.4f);

		if (gameObject.transform.position.x > 3) {
			gameObject.transform.position = new Vector3(3f, yLock, 4.4f);
		}
		if (gameObject.transform.position.x < -3) {
			gameObject.transform.position = new Vector3(-3f, yLock, 4.4f);
		}

		if (Input.GetMouseButtonDown(0)) {
			GameObject newProjectile = (GameObject)Instantiate(projectile, 
			                                       new Vector3(projectileSpawner.transform.position.x, projectileSpawner.transform.position.y, projectileSpawner.transform.position.z), 
			                                       new Quaternion(0f,0f,0f,0f));

		}
	}
}
