using UnityEngine;
using System.Collections;
using System;

public class SongPlayer : MonoBehaviour {
	SongLoader songLoader;
	float elapsedTime = 0f;
	string playingSong = null;

	// Use this for initialization
	void Start () {
		songLoader = GameObject.Find("SongManager").GetComponent<SongLoader> ();
		//PlaySong ("Assets/Resources/Songs/song.txt");
	}
	
	// Update is called once per frame
	void Update () {
		if (playingSong != null) {
			elapsedTime += Time.deltaTime;
			int second = (int)Math.Round (elapsedTime);
			Debug.Log ("Asking for " + second);
			IList buttons = songLoader.GetButtons (second);
			foreach(GameObject button in buttons) {
				button.SetActive(true);			
			}
			if (songLoader.SongHasEnded (second)) {
				playingSong = null;
			}
		}
	}

	public void PlaySong(string songPath) {
		playingSong = songPath;
		songLoader.PlaySong (playingSong);
		elapsedTime = 0f;
	}
}
