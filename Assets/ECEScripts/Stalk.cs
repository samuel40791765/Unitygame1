using UnityEngine;
using System.Collections;

public class Stalk : MonoBehaviour {
    public GameObject prey;
	public Transform target;
	public GameObject onfire;
	public GameObject spiderfire;
	static public bool isdead = false;
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
		if(Time.timeScale==1) {
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
	}

	void OnCollisionEnter (Collision other) {
        if (other.gameObject.name == "drop")
        {
            foundprey = true;
            StartCoroutine(waitsec());
            run = false;
        }
		if (onfire.activeSelf==true && other.gameObject.name=="drop" && !isdead) {
            run = false;
			isdead=true;
			StartCoroutine(waitsec());
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
		if (!isdead) {
			this.GetComponent<Animation>().Play ("attack2",PlayMode.StopAll);
			finalscore.hitstaken++;
			yield return new WaitForSeconds(2);
			foundprey=false;
		}
		if(isdead) {
			spiderfire.SetActive(true);
			this.GetComponent<Animation>().Play ("death1",PlayMode.StopAll);
			yield return new WaitForSeconds(2);
			Destroy(this.gameObject);
			finalscore.deathcount=finalscore.deathcount+1;
		}
	}
	
}
