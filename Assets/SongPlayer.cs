using UnityEngine;
using System.Collections;
using System;

public class SongPlayer : MonoBehaviour {
	SongLoader songLoader;
	float elapsedTime = 0f;

	// Use this for initialization
	void Start () {
		songLoader = GameObject.Find("SongManager").GetComponent<SongLoader> ();
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime;
		int second = (int)Math.Round (elapsedTime);
		Debug.Log ("Asking for " + second);
		IList buttons = songLoader.GetButtons (second);
		foreach(GameObject button in buttons) {
			button.SetActive(true);			
		}
	}
}
