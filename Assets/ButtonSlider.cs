using UnityEngine;
using System.Collections;
using System;

public class ButtonSlider : MonoBehaviour {
	int speed = 1;
	float alpha = 1f;
	float fadeOutSpeed = 2f;
	float epsilon = 1f;
	float optimumHitZ = -4f;

	void Update () {
		if (this.gameObject.activeSelf) {
			Vector3 poz = transform.position;
			transform.Translate (new Vector3 (0, 0, -1) * Time.deltaTime * speed);
			if (transform.localPosition.z < optimumHitZ) {
				HideObject ();
			}
		}
	}

	void HideObject() {
		alpha -= (fadeOutSpeed*Time.deltaTime);
		if (alpha < 0f) {
			this.gameObject.SetActive (false);
		} else {
			Color temp = this.gameObject.GetComponent<Renderer> ().material.color;
			temp.a = alpha;
			this.gameObject.GetComponent<Renderer> ().material.color = temp;
		}
	}

	public bool HitCorrect() {
		if (Math.Abs (transform.localPosition.z - optimumHitZ) < epsilon) {
			return true;
		}
		return false;
	}
}
