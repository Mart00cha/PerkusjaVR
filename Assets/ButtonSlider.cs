using UnityEngine;
using System.Collections;
using System;

public class ButtonSlider : MonoBehaviour {
	int speed = 1;
	float alpha = 1f;
	float fadeOutSpeed = 2f;
	float epsilon = 0.5f;
	float optimumHitZ = 0f;

	void Update () {
		if (this.gameObject.activeSelf) {
			Vector3 poz = transform.position;

			transform.Translate (new Vector3 (0, 0, -1) * Time.deltaTime * speed);
			if (poz.z < 0.5f) {
				HideObject ();
			}
		}
	}

	void HideObject() {
		alpha -= (fadeOutSpeed*Time.deltaTime);
		if (alpha < 0f) {
			this.gameObject.SetActive (false);
			ScoreManager manager = GameObject.Find("Score").GetComponent<ScoreManager> ();
			manager.ApplyPoints (ScoreManager.POINTS_TYPES.GOOD);
		} else {
			Color temp = this.gameObject.GetComponent<Renderer> ().material.color;
			temp.a = alpha;
			this.gameObject.GetComponent<Renderer> ().material.color = temp;
		}
	}

	public bool HitCorrect() {
		if (Math.Abs (transform.position.z - optimumHitZ) < epsilon) {
			return true;
		}
		return false;
	}
}
