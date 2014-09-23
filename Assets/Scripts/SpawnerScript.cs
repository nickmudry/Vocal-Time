using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	float spawnX;
	public float spawnY;
	public float timer;
	public float timerReset = 500f;
	public GameObject enemyShip;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
		Random.seed = System.DateTime.Now.Second + System.DateTime.Now.Minute * System.DateTime.Now.Millisecond;
		spawnX = Random.Range(-3f, 3f);
		if (timer >= timerReset)
		{
			GameObject newProjectile = (GameObject)Instantiate(enemyShip, new Vector3(spawnX,spawnY, 4f), new Quaternion(0f,0f,0f,0f));
			timer = 0f;
		}
	}



}
