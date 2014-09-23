using UnityEngine;
using System.Collections;

public class NoteBlockScript : MonoBehaviour {
	public float timeScaleModifier = 1f;
	float micInput;
	AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
//		MicControlC.
//		gameObject.transform.localScale=Vector3(1,MicControlC.loudness,1);
	}

	void MicVolume(float volume)
	{
		if (volume >= .1f) {
			micInput = volume;
			Time.timeScale = (micInput * timeScaleModifier) + 0.5f;
			if (Time.timeScale < .25f)
				audio.pitch = 0.25f;
			else if (Time.timeScale < .5f)
				audio.pitch = 0.5f;
			else if (Time.timeScale < 1.1f)
				audio.pitch = 1.1f;
			else if (Time.timeScale > 1.5f)
				audio.pitch = 1.5f;
			else if (Time.timeScale > 2f)
				audio.pitch = 2f;
			else if (Time.timeScale > 3f)
				audio.pitch = 3f;
		}
	}
}
