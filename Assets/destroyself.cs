using UnityEngine;
using System.Collections;

public class destroyself : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (Wait());
	}
	
	IEnumerator Wait () {
		yield return new WaitForSeconds (1.5f);
		Destroy (this.gameObject);
	}
}
