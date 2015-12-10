using UnityEngine;
using System.Collections;

public class drophealth : MonoBehaviour {
    public GameObject water;
    private float timer=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timer = timer + Time.deltaTime;
        water.transform.localPosition = water.transform.localPosition-new Vector3(0,timer/20,0);
        
    }
}
