using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HitManager : MonoBehaviour {
	private ScoreManager scoreManager;
	private ButtonSlider buttonSlider;
	private Dictionary<string, string> drumsToButtons;
	private SongPlayer songPlayer;

	void Start() {
		scoreManager = GameObject.Find("Score").GetComponent<ScoreManager> ();
		songPlayer = GameObject.Find("SongManager").GetComponent<SongPlayer> ();
	

		drumsToButtons = new Dictionary<string, string>();
		drumsToButtons ["Drum0"] = "0";
		drumsToButtons ["Drum1"] = "1";
		drumsToButtons ["Drum2"] = "2";
		drumsToButtons ["Drum3"] = "3";
		drumsToButtons ["Drum4"] = "4";
	}

	public void HitEvent(string drumId) {
		Debug.Log ("HIT EVENT: " + drumId);
		IList buttons = songPlayer.CurrentButtons ();
		if (buttons != null) {
			foreach (GameObject button in buttons) {
				string buttonId = drumsToButtons [drumId];
				Debug.Log ("BUTTON ID: " + buttonId);
				if (button.name.Equals (buttonId)) {
					Debug.Log ("FOUND BUTTON" + button.name);
					if (button.GetComponent<ButtonSlider> ().HitCorrect ()) {
						Debug.Log ("HIT CORRECT!");
						scoreManager.ApplyPoints (ScoreManager.POINTS_TYPES.GOOD);
					}
				}
			}
		}
	}
}
