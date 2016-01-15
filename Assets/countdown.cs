using UnityEngine;
using System.Collections;

public class countdown : MonoBehaviour {
	private float starttime;
	private int timeleft;
	public GUIStyle style;
	static public bool show;
	// Use this for initialization
	void Start () {
		starttime = 6;
		show = true;
		destination.AtEnd = true;
		StartCoroutine (hide ());
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (show) {
			if(timeleft!=0){
				GUI.Label (new Rect (650, 750, 300, 50), (timeleft.ToString ()), style);
			}
			else{
				GUI.Label (new Rect (650, 750, 300, 50), ("GO!"), style);
			}
			starttime = starttime - Time.deltaTime;
			timeleft=(int)starttime;
		}
	}



	IEnumerator hide() {
		yield return new WaitForSeconds (3);
		show = false;
		destination.AtEnd = false;
	}
}
