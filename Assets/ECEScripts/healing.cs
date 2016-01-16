using UnityEngine;
using System.Collections;

public class healing : MonoBehaviour {
    public GameObject water;
	public GameObject healanim;

    static public int healcount;
	// Use this for initialization
	void OnCollisionEnter(Collision other) {
		if (other.gameObject.name == "drop")
		{
 
            water.transform.position = water.transform.position + new Vector3(0, 5f, 0);
			healanim.SetActive (true);
			healanim.GetComponentInChildren<ParticleEmitter>().Emit();
			healcount++;
			Destroy(this.gameObject);
		}
	}
}
