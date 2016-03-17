using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class WebCameraSnapshot : MonoBehaviour {
    WebCamTexture webCamTexture;

    // Use this for initialization
    void Start() {
        webCamTexture = new WebCamTexture();
        GetComponent<RawImage>().texture = webCamTexture;
        GetComponent<RawImage>().material.mainTexture = webCamTexture;
        webCamTexture.Play();
    }

}
