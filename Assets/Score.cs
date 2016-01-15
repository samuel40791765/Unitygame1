using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
	public Text Timeshow;
	static public float timeused;



	// Use this for initialization
	void Start () {
		timeused = 0;
		Timeshow.text= "TimeUsed: " +timeused.ToString() +" seconds";
		finalscore.deathcount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (countdown.show) {
			timeused=0;
		}
		timeused = Time.deltaTime + timeused;
		Timeshow.text= "TimeUsed: " +timeused.ToString()+" seconds";

	}


}
