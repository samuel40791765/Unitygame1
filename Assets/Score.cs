using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {
    public Text dropcollect;
	public Text Timeshow;
	static public float timeused;



	// Use this for initialization
	void Start () {
		timeused = 0;
        dropcollect.text = "Collected: " +finalscore.healthscore.ToString() +" drops";
		Timeshow.text= "TimeUsed: " +timeused.ToString() +" seconds";
		finalscore.deathcount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (countdown.show) {
			timeused=0;
		}
		timeused = Time.deltaTime + timeused;
        dropcollect.text = "Collected: " + healing.healcount + " drops";
        Timeshow.text= "TimeUsed: " +timeused.ToString()+" seconds";

	}


}
