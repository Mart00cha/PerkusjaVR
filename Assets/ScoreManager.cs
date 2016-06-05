﻿using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public enum POINTS_TYPES {
		GOOD = 20,
		BAD = -10
	};

	Text scoreText;
	private long score = 0;

	void Start () {
		Application.targetFrameRate = 60;
		scoreText = GameObject.Find("Score").GetComponent<Text>();
	}

	void Update () {
		scoreText.text = "SCORE: " + score;
	}

	public void ApplyPoints(POINTS_TYPES points) {
		score += (long)points;
	}
}