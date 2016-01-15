﻿using UnityEngine;
using System.Collections;



public class destination : MonoBehaviour {
	float Timer;
	public GameObject ball;
	public GUIStyle style;
	private bool passed=false;
	private bool failed=false;
	static public bool AtEnd = false;

	void Update(){
		if (drophealth.health <= 43) {
			failed=true;
		}
	}
	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		Debug.Log("Player OnTriggerEnter");

		ball.GetComponent<Rigidbody>().velocity = new Vector3(1,1,1);
		AtEnd = true;
		passed = true;
		ResetTimer();

	}

	void OnGUI(){
		if (passed) {
			GUI.Label (new Rect (150, 650, 300, 50), "You Passed!!", style);
		}
		if (failed) {
			GUI.Label (new Rect (50, 650, 300, 50), "You Dried Up...", style);
		}
	}
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		ball.GetComponent<Rigidbody>().velocity = new Vector3(0,1,0);
		Timer += Time.deltaTime;
		if(Timer >= 3.0)
		{
			AtEnd=false;
			Stalk.isdead=false;
			passed=false;
			ResetTimer();
			Application.LoadLevel("LevelEnd");
		}
	}



	void OnTriggerExit(Collider other)
	{
		Debug.Log("Player OnTriggerExit"); 
		ResetTimer();
	}



	void ResetTimer()
	{
		 Timer= 0.0f;
	}
}
