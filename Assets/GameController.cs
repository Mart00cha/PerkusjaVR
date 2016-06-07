using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    GameObject camera;

	// Use this for initialization
	void Start () {
        camera = GameObject.Find("Camera");
	}

    // change camera rotation to drums
    void setupCamera() {
        GameObject.Find("Camera").transform.eulerAngles = new Vector3(0, 0, 0);
    }

    public void OnSongsSelected() {
        GameObject.Find("Score").GetComponent<ScoreManager>().Reset();
        setupCamera();
        print("Songs...");
    }

    public void OnFreestyleSelected() {
        GameObject.Find("Score").GetComponent<ScoreManager>().Reset();
        setupCamera();
        print("Freestyle...");
    }

    void Update () {
    }
}
