using UnityEngine;
using System.Collections;

public class drophealth : MonoBehaviour {
    public GameObject water;
	static public float health;
    private Vector3 top;
    private Vector3 bottom;
	// Use this for initialization
	void Start () {
        top = water.transform.position;
        bottom = top - new Vector3(0, 140, 0);
		health=(water.transform.position.y - bottom.y)*100 /140;
    }
	
	// Update is called once per frame
	void Update () {
		health=(water.transform.position.y - bottom.y)*100 /140;
//		Debug.Log (+health);
		if (Time.timeScale == 1 && !countdown.show && !destination.AtEnd) {
			water.transform.position = water.transform.position-new Vector3(0,0.05f,0);
		}

       if(health<=43)
        {
			this.GetComponent<MeshRenderer>().enabled = false;
			StartCoroutine(wait ());
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name=="tree1"|| other.gameObject.name == "tree2"||other.gameObject.name == "tree3")
        {
            water.transform.position = water.transform.position - new Vector3(0, 5, 0);
        }
    }

	IEnumerator wait() {
		yield return new WaitForSeconds (3);
		Application.LoadLevel("LevelEnd");
	}
}
