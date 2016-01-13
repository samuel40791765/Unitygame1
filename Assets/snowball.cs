using UnityEngine;
using System.Collections;

public class snowball : MonoBehaviour {
	public GameObject water;
	// Use this for initialization
	void OnCollisionEnter (Collision other) {
		if (other.gameObject.name == "Snowball(Clone)" && !Stalk.isdead)
		{
			Debug.Log("Player OnCollisionEnter");
			water.transform.position = water.transform.position - new Vector3(0, 4f, 0);
			Destroy (other.gameObject);
		}

	}
}
