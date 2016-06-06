using UnityEngine;
using System.Collections;

public class HitManager : MonoBehaviour {
	private ScoreManager scoreManager;
	private ButtonSlider buttonSlider;

	void Start() {
		scoreManager = GameObject.Find("Score").GetComponent<ScoreManager> ();
	}

	void HitEvent() {
//		if (buttonSlider.HitCorrect ()) {
//			scoreManager.ApplyPoints (ScoreManager.POINTS_TYPES.GOOD);
//		}
	}
}
