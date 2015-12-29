using UnityEngine;
using System.Collections;

public class healing : MonoBehaviour {
	public GameObject water;
	public GameObject healanim;
	// Use this for initialization
	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "drop")
		{
			water.transform.position = water.transform.position + new Vector3(0, 5f, 0);
			healanim.SetActive (true);
			healanim.GetComponentInChildren<ParticleEmitter>().Emit();
			Destroy(this.gameObject);
		}
	}
	
}
