using UnityEngine;
using System.Collections;

public class Audience : MonoBehaviour {
    public Animation animation;
    private ScoreManager scoreManager;

    void Start() {
    	Debug.Log ("ANIMATION START!");
        animation = GetComponent<Animation>();
        scoreManager = GameObject.Find("Score").GetComponent<ScoreManager> ();
		animation.Play("idle");
    }

    void Update(){
    	long score = scoreManager.GetScore();
		if(score <= 10){
    		animation.Play("idle");
    	}
    	if( score > 10 && score <= 20){
    		animation.Play("applause");
    	}
    	if( score > 20  && score <= 30){
    		animation.Play("applause2");
    	}
    	if(score > 30 && score <= 40){
    		animation.Play("celebration");
    	}
    	if(score > 40 && score <= 50){
    		animation.Play("celebration2");
    	}
    	if(score > 50 && score <= 60){
    		animation.Play("celebration3");
    	}
    }
}