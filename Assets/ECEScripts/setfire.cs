using UnityEngine;
using System.Collections;


public class setfire : MonoBehaviour {
	public GameObject trigger;
	public GameObject oil;
	public GameObject fire;
    public AudioClip firesound;
    public AudioSource source;
	// Use this for initializatioㄙ
    void Awake()
    {
        source = source.GetComponent<AudioSource>();
    }
	void OnTriggerEnter (Collider Other) {
		if (trigger.name == "OilCan") {
			if(fire.activeInHierarchy==false) {
				oil.SetActive(true);
			}
		}
		if (trigger.name == "Fire") {
			if(oil.activeInHierarchy==true) {
                source.Play();
				fire.SetActive(true);
				oil.SetActive(false);
			}
		}
	}
}
