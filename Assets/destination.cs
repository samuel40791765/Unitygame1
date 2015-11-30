using UnityEngine;
using System.Collections;

public class destination : MonoBehaviour {
	float Timer;
	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		Debug.Log("Player OnTriggerEnter");
		ResetTimer();
	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		Timer += Time.deltaTime;
		if(Timer >= 2.0)
		{
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
