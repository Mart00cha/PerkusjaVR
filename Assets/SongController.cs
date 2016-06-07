using UnityEngine;
using System.Collections;

public class SongController : MonoBehaviour {

    void OnMouseDown() {
        GameObject.Find("Camera").GetComponent<GameController>().OnSongsSelected();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
