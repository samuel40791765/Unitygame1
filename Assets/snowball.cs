using UnityEngine;
using System.Collections;

public class snowball : MonoBehaviour {
	public GameObject water;
	public GameObject player;
	// Use this for initialization
	void OnCollisionEnter (Collision other) {
		if (other.gameObject.name == "Snowball(Clone)" && !Stalk.isdead)
		{
			Debug.Log("Player OnCollisionEnter");
			water.transform.position = water.transform.position - new Vector3(0, 4f, 0);
			finalscore.hitstaken++;
			Destroy (other.gameObject);
		}


	}


}
