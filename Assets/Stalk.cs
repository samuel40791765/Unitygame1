using UnityEngine;
using System.Collections;

public class Stalk : MonoBehaviour {
    public GameObject prey;
	public Transform target;
    private Vector3 dir;
    private float dis;
    private float slow;
	private bool foundprey;
    private bool run;
    // Use this for initialization
    void Start () {
		foundprey = false;
        run = true;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt(target);
        dis = Vector3.Distance(this.transform.position, prey.transform.position);
        if (dis <= 60&&run==true)
        {
            slow = dis*5;
            dir = prey.transform.position - this.transform.position;
			if (foundprey==false) {
				this.GetComponent<Animation>().Play ("walk");
			}
            this.transform.Translate(dir / slow);
        }
	}

	void OnCollisionEnter (Collision other) {
        if (other.gameObject.name == "drop")
        {
            foundprey = true;
            StartCoroutine(waitsec());
            run = false;
        }
	}
    void OnCollisionExit(Collision other)
    {
        if(other.gameObject.name=="drop")
        {
            run = true;
        }
    }


    IEnumerator waitsec() {
		this.GetComponent<Animation>().Play ("attack2",PlayMode.StopAll);
		yield return new WaitForSeconds(2);
		foundprey=false;
	}
}
