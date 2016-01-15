using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	public Text Timeshow;
	private float timeused;
	// Use this for initialization
	void Start () {
		StartCoroutine (wait ());
	}
	
	// Update is called once per frame
	void Update () {
		if (countdown.show) {
			timeused=0;
		}
		timeused = Time.deltaTime + timeused;
		Timeshow.text= "TimeUsed: " +timeused.ToString();
	}

	IEnumerator wait() {
		yield return new WaitForSeconds (3);
		timeused = 0;
		Timeshow.text= "TimeUsed: " +timeused.ToString();
	}
}
