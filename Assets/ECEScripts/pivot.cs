using UnityEngine;
using System.Collections;

public class pivot : MonoBehaviour {
    public GameObject drop;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = drop.transform.position;
	}
}
