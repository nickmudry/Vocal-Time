using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
	TextMesh textStuff;
	// Use this for initialization
	void Start () {
		textStuff = GetComponent<TextMesh>();
	}

	// Update is called once per frame
	void Update () {
		textStuff.text = ("Score: " + PlayerPrefs.GetInt("Score").ToString());
	}
}
