using UnityEngine;
using System.Collections;

public class snowman : MonoBehaviour {

	// Use this for initialization
	public GameObject prey;
	public GameObject prefab;
	private float dis;
	private bool indis;

	public void Start() {
		dis = Vector3.Distance(this.transform.position, prey.transform.position);
		indis = false;
		if (dis <= 50) {
			InvokeRepeating ("LaunchSnowball", 1, 1f);
			indis=true;
		}
	}

 	public void Update() {
		dis = Vector3.Distance(this.transform.position, prey.transform.position);
		if (dis > 50 && indis) {
			CancelInvoke("LaunchSnowball");
			indis=false;
		}
		if (!indis && dis < 50) {
			indis=true;
			InvokeRepeating ("LaunchSnowball", 1, 1f);
		}
	}

	void LaunchSnowball() {
		GameObject Snowball = (GameObject)Instantiate (prefab,transform.position+(transform.forward*2)+(transform.up*2),transform.rotation);
		Snowball.GetComponent<Rigidbody>().AddForce(transform.forward*1500f);
	}

}
