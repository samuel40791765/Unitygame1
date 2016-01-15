using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class finalscore : MonoBehaviour {
	private float timescore;
	private int deathscore;
	private int healthscore;
	private int final;
	static public int deathcount=0;

	public Text timesc;
	public Text deathsc;
	public Text healthsc;
	public Text finalsc;
	// Use this for initialization
	void Start () {
		if (destination.passed) {
			timescore = (int)Score.timeused - 3;
			deathscore=deathcount;
			healthscore=(int)drophealth.health-43;
			final=(100-(int)timescore)+(deathscore*10)+(healthscore*2);
			timesc.text = "Time: " +timescore;
			deathsc.text="Enemies Slayed: "+deathscore;
			healthsc.text="Health Left: "+healthscore;
			finalsc.text="Score: "+final;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
