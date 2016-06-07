using UnityEngine;
using System.Collections;

public class ResetController : MonoBehaviour {
    
    void OnMouseDown()
    {
        GameObject.Find("Camera").GetComponent<GameController>().OnSongsSelected();
    }
}
