using UnityEngine;
using System.Collections;

public class grasssound : MonoBehaviour {
    public AudioClip grass;
    private AudioSource source;
	// Use this for initialization
	void Awake () {
        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="drop")
        {
            source.PlayOneShot(grass, 1F);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "drop")
        {
            source.Stop();
        }
    }
}
