using UnityEngine;
using System.Collections;

public class ButtonSlider : MonoBehaviour {
	int speed = 1;
	float alpha = 1f;
	float fadeOutSpeed = 2f;

	void Update () {
		Vector3 poz = transform.position;

		if (poz.z > 0.5) {
			transform.Translate (new Vector3 (0, 0, -1) * Time.deltaTime * speed);
		}
		else {
			HideObject ();

		}
	}

	void HideObject() {
		alpha -= (fadeOutSpeed*Time.deltaTime);
		if (alpha < 0) {
			this.gameObject.SetActive (false);
			ScoreManager manager = GameObject.Find("Score").GetComponent<ScoreManager> ();
			manager.ApplyPoints (ScoreManager.POINTS_TYPES.GOOD);
		} else {
			Color temp = this.gameObject.GetComponent<Renderer> ().material.color;
			temp.a = alpha;
			this.gameObject.GetComponent<Renderer> ().material.color = temp;
		}
	}
}
