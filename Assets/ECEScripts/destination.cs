using UnityEngine;
using System.Collections;



public class destination : MonoBehaviour {
	float Timer;
	public GameObject ball;
	static public bool AtEnd = false;

	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		Debug.Log("Player OnTriggerEnter");

		ball.GetComponent<Rigidbody>().velocity = new Vector3(1,1,1);
		AtEnd = true;
		
		ResetTimer();

	}
	
	// Update is called once per frame
	void OnTriggerStay (Collider other) {
		ball.GetComponent<Rigidbody>().velocity = new Vector3(0,1,0);
		Timer += Time.deltaTime;
		if(Timer >= 2.0)
		{
			AtEnd=false;
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
