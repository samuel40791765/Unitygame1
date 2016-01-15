using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mainmenu : MonoBehaviour {
    public Canvas level;
    public Canvas illustration;
    public Button start;
    public Button tutorial;
	public static int scene;
    // Use this for initialization
	void Start () {
        level = level.GetComponent<Canvas>();
        illustration = illustration.GetComponent<Canvas>();
        start = start.GetComponent<Button>();
        tutorial = tutorial.GetComponent<Button>();
        level.enabled = false;
        illustration.enabled = false;

    }
    public void StartPress()
    {
        level.enabled = true;
        start.enabled = false;
        tutorial.enabled = false;
    }
    public void DesertPress()
    {
		scene = 1;
        Application.LoadLevel("Scene1");
    }
    public void ForestPress()
    {
		scene = 2;

        Application.LoadLevel("Scene2");
    }
	public void IcePress()
    {
		scene = 3;
        Application.LoadLevel("Scene3");
    }
    public void IllustratePress()
    {
        illustration.enabled = true;
        start.enabled = false;
        tutorial.enabled = false;
    }
    public void BackPress()
    {
        illustration.enabled = false;
        start.enabled = true;
        tutorial.enabled = true;
    }
    
	// Update is called once per frame
	
}
