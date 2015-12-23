using UnityEngine;
using System.Collections;

public class dry : MonoBehaviour {
	public GameObject water;
	// Use this for initialization
	void OnCollisionEnter (Collision other) {
		if (other.gameObject.name == "drop")
		{
			Debug.Log("Player OnCollisionEnter");
			water.transform.position = water.transform.position - new Vector3(0, 15f, 0);
		}
	}

	void OnTriggerEnter (Collision other) {
		if (other.gameObject.name == "drop")
		{
			Debug.Log("Player OnCollisionEnter");
			water.transform.position = water.transform.position - new Vector3(0, 15f, 0);
		}
	}
}
