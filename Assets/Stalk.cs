using UnityEngine;
using System.Collections;

public class Stalk : MonoBehaviour {
    public GameObject prey;
    private Vector3 dir;
    private float dis;
    private float slow;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
        dis = Vector3.Distance(this.transform.position, prey.transform.position);
        if (dis <= 60)
        {
            slow = dis*10;
            dir = prey.transform.position - this.transform.position;
            this.transform.Translate(dir / slow);
        }
	}
}
