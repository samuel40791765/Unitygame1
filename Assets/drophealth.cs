using UnityEngine;
using System.Collections;

public class drophealth : MonoBehaviour {
    public GameObject water;
	static public float health=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        health = health + Time.deltaTime;
		Debug.Log (+ health);
        water.transform.localPosition = water.transform.localPosition-new Vector3(0,0.1f,0);
        if (health >= 32) {
			Application.LoadLevel("LevelEnd");
		}
    }
}
