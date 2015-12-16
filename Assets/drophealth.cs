using UnityEngine;
using System.Collections;

public class drophealth : MonoBehaviour {
    public GameObject water;
	private float health;
    private Vector3 top;
    private Vector3 bottom;
	// Use this for initialization
	void Start () {
        top = water.transform.position;
        bottom = top - new Vector3(0, 140, 0);
    }
	
	// Update is called once per frame
	void Update () {
        health=(water.transform.position.y - bottom.y)*100 /140;
        Debug.Log (+health);
        water.transform.position = water.transform.position-new Vector3(0,0.1f,0);
       if(health<=0)
        {
            Application.LoadLevel("LevelEnd");
        }
    }
}
