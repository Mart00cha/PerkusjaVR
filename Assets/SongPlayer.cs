using UnityEngine;
using System.Collections;
using System;

public class SongPlayer : MonoBehaviour {
	SongLoader songLoader;
	float elapsedTime = 0f;
	string playingSong = null;
	private IList currentButtons = null;
	// Use this for initialization
	void Start () {
		songLoader = GameObject.Find("SongManager").GetComponent<SongLoader> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playingSong != null) {
			elapsedTime += Time.deltaTime;
			int second = (int)Math.Round (elapsedTime);
			currentButtons = songLoader.GetButtons (second);
			foreach(GameObject button in currentButtons) {
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
        GameObject.Find("BottomBorder").SetActive(true);
    }

	public void StopSong() {
		if (playingSong != null) {
			playingSong = null;
		}
        GameObject.Find("BottomBorder").SetActive(false);

    }

	public IList CurrentButtons() {
		return currentButtons;
	}
}
