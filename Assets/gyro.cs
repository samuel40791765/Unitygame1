﻿using UnityEngine;
using System.Collections;

public class gyro : MonoBehaviour {
    public GameObject ball;
    private bool isHasGyro = false;
    Vector3 force;
    // Use this for initialization
    void Start () {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            isHasGyro = true;
        }
	
	}
	
	// Update is called once per frame
	void Update () {
        float x;
        float y;
        float z;
        if(isHasGyro)
        {
            x = Input.gyro.attitude.x;
            y = Input.gyro.attitude.y;
            z = Input.gyro.attitude.z;
            force = new Vector3(-x*50F , 0.0F, -y*50F);


        }
        else
        {
            x = Input.acceleration.x;
            y = Input.acceleration.y;
            z = Input.acceleration.z;
            force = new Vector3(-x * 50F, 0.0F, -y * 50F);
        }

        ball.GetComponent<Rigidbody>().AddForce(force);
	}
}
