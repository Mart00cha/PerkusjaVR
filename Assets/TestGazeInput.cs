using UnityEngine;
using System.Collections;

public class TestGazeInput : MonoBehaviour {

    TextMesh text;
    GameObject sphere;
    bool destroyed = false;

    public void OnSelectItem()
    {
        text.text = "lol " + destroyed.ToString();
        sphere.SetActive(destroyed);
        destroyed = !destroyed;
        print("what you gonna do");
    }

	// Use this for initialization
	void Start () {
	    text = GameObject.Find("lol").GetComponent<TextMesh>();
        sphere = GameObject.Find("Sphere");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
