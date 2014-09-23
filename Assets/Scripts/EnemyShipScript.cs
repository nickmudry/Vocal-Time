using UnityEngine;
using System.Collections;

public class EnemyShipScript : MonoBehaviour {
	public float speed = .1f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rigidbody2D.AddForce(new Vector2(0f, speed * -1f));
	}

	void OnCollisionEnter2D(Collision2D col) {
		if (col.gameObject.tag == "Projectile"){
			PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 100);
			Destroy(col.gameObject);
			Destroy(gameObject);
		}
		if (col.gameObject.tag == "Player"){
			GameObject gameOverScreen = GameObject.Find ("MasterObject");
			gameOverScreen.SendMessage ("GameOver");
			Destroy(col.gameObject);
		}
	}
}
