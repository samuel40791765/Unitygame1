using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {
    public GameObject ball;
    public GameObject sight;
    Vector3 sight_pos;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        sight_pos = ball.transform.position;
        sight_pos = sight_pos + new Vector3(0, 10, 7);
        sight.transform.position = sight_pos;
	}
}
