using UnityEngine;
using System.Collections;

public class countdown : MonoBehaviour {
	private float starttime;
	private int timeleft;
	public GUIStyle style;
	public GUIStyle style2;
	static public bool show;
	static public bool on;
	// Use this for initialization
	void Start () {
		starttime = 6;
		on = true;
		show = true;
		destination.AtEnd = true;
		StartCoroutine (hide ());
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (show) {
			if(mainmenu.scene==1){
				GUI.Label (new Rect (200, 200, 300, 300),("Watch out for Spiders!\n Grass sucks Water!"), style2);
			}
			if(mainmenu.scene==2){
				GUI.Label (new Rect (200, 200, 300, 300), ("Watch out for Spiders!\n Can you kill them?"), style2);
			}
			if(mainmenu.scene==3){
				GUI.Label (new Rect (50, 200, 300, 300), ("Watch out for Snowballs!\n      They come fast!"), style2);
			}
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
		on = false;
		destination.AtEnd = false;
	}
}
