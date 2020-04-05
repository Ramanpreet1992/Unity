using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour {
    public Rigidbody rb1;
    public float forwardForce = 200f;
    public float side = 100f;
    // Use this for initialization
    void Start () {
        rb1.AddForce(0, 0, forwardForce * Time.deltaTime);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        rb1.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {

            rb1.AddForce(side * Time.deltaTime,0, 0);
        }
        if (Input.GetKey("a"))
        {

            rb1.AddForce(-side * Time.deltaTime, 0, 0);
        }

    }
}
