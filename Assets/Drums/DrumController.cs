using UnityEngine;
using System.Collections;

public class DrumController : MonoBehaviour
{
    public string inputName = "Jump";

    private Rigidbody rigidbody;
    private AudioSource audioSource;
    

	// Use this for initialization
	void Start () {

        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButtonDown(inputName))
	    {
	        MakeSound();
	    }
	}

    void FixedUpdate()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        MakeSound();
    }

    void MakeSound()
    {
        audioSource.Play();
    }

}
