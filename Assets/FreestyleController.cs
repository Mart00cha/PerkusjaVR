using UnityEngine;
using System.Collections;

public class FreestyleController : MonoBehaviour {

    void OnMouseDown() {
        GameObject.Find("Camera").GetComponent<GameController>().OnFreestyleSelected();
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
