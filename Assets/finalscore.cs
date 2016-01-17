using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class finalscore : MonoBehaviour {
	private float timescore;
	private int deathscore;
	static public int healthscore;
	private int final;
	static public int hitstaken = 0;
	static public int deathcount=0;

	public Text timesc;
	public Text deathsc;
	public Text healthsc;
	public Text hitssc;
	public Text finalsc;
	// Use this for initialization
	void Start () {
		if (destination.passed) {
			timescore = (int)Score.timeused - 3;
			deathscore=deathcount;
			healthscore=healing.healcount;
			final=(150-(int)timescore)+(deathscore*10)+(healthscore*2)-(hitstaken*5);
			timesc.text = "Time: " +timescore;
			deathsc.text="Enemies Slayed: "+deathscore;
			healthsc.text="Water Collected: "+healing.healcount;
			hitssc.text="Hits Taken: "+hitstaken;
			finalsc.text="Score: "+final;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
