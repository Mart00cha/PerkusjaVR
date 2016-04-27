using System;
using UnityEngine;
using System.Collections;

public class StickController : MonoBehaviour {

    public float delay=2;

    private Rigidbody rb;
    private Vector3 pos2;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        Vector3 spd = (pos2 - rb.position) / Time.deltaTime/delay;
        rb.velocity = spd;
    }

    public void NewPosition(Single x, Single y, Single z)
    {
        
        pos2 = new Vector3(x, y, z);
    }
}
