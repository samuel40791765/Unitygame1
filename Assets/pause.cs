using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pause : MonoBehaviour {
	public Canvas pausemenu;
	public Canvas pausebutton;
	// Use this for initialization
	void Start () {
		pausemenu = pausemenu.GetComponent<Canvas>();
		pausebutton = pausebutton.GetComponent<Canvas> ();
		pausebutton.enabled = true;
		pausemenu.enabled = false;
	}
	
	public void PausePress() {
		Debug.Log("Pause");
		Time.timeScale =0;
		pausemenu.enabled = true;
		pausebutton.enabled = false;
	}

	public void resume() {
		Time.timeScale = 1;
		pausemenu.enabled = false;
		pausebutton.enabled = true;
	}

	public void retry() {
		Application.LoadLevel (Application.loadedLevel);
		Time.timeScale = 1;
		pausemenu.enabled = false;
		pausebutton.enabled = true;
	}
}
