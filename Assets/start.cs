using UnityEngine;
using System.Collections;

public class start : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        int touchCount = Input.touchCount;
        if (touchCount > 0)
        {
            for (int i = 0; i < touchCount; i++)
            {
                Touch touch = Input.GetTouch(i);
                if (this.GetComponent<GUITexture>().HitTest(touch.position))
                {
					if (this.name == "Start")
                        Application.LoadLevel("Scene1");
                }
            }
        }

    }
}

