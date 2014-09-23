using UnityEngine;
using System.Collections;

public class MasterObject : MonoBehaviour {
	public bool gameOver;
	public GameObject gameOverObject;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("Score", 0);
	}
	
	// Update is called once per frame
	void Update () {
	 if (gameOver) {
			gameOverObject.SetActive(true);
			if (Input.GetMouseButtonDown(0))
			{
				Application.LoadLevel("GameScene");
			}
		}
	}

	void GameOver () {
		gameOver = true;
		//SHOW SOME TEXT THAT SAYS GAME OVER
	}
}
