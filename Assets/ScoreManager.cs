using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public enum PointsTypes {
        GOOD = 20,
        BAD = -10
    };

    Text scoreText;
    private long score = 0;

    void Start () {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }
	
    void Update () {
        scoreText.text = "SCORE: " + score;
    }

    public void ResetPoints() {
        score = 0;
    }

    public void ApplyPoints(PointsTypes points) {
        score += (long)points;
    }
}
