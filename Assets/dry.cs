using UnityEngine;
using System.Collections;

public class dry : MonoBehaviour {
	public GameObject water;
	public GameObject ball;
	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		Debug.Log("Player OnTriggerEnter");
		drophealth.health = drophealth.health + 1;
		water.transform.localPosition = water.transform.localPosition-new Vector3(0,3.3f,0);
	}
}
