using UnityEngine;
using System.Collections;

public class levelupsound : MonoBehaviour {
    public AudioClip levelup;
    private AudioSource source;
	// Use this for initialization
	void Awake()
    {
        source =GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void OnCollisionEnter(Collision other)
    {
        if (other.collider.gameObject.layer == LayerMask.NameToLayer("water"))
        {
            print("enter");
            source.PlayOneShot(levelup,1F);
            
        }
    }
}
