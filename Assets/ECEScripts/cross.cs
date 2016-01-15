using UnityEngine;
using System.Collections;

public class cross : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 1) {
			this.transform.Rotate (0, 1, 0);
		}
	}
}
