using UnityEngine;
using System.Collections;


public class setfire : MonoBehaviour {
	public GameObject trigger;
	public GameObject oil;
	public GameObject fire;
	// Use this for initializatioㄙ

	void OnTriggerEnter (Collider Other) {
		if (trigger.name == "OilCan") {
			if(fire.activeInHierarchy==false) {
				oil.SetActive(true);
			}
		}
		if (trigger.name == "Fire") {
			if(oil.activeInHierarchy==true) {
				fire.SetActive(true);
				oil.SetActive(false);
			}
		}
	}
}
