using UnityEngine;
using System.Collections;

public class split : MonoBehaviour
{
    public GameObject drop;
    public GameObject Clone;
    public static bool issplit = false;
    public static bool hold = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int touchcount = Input.touchCount;
        if (touchcount > 0)
        {
            for (int i = 0; i < touchcount; i++)
            {
                Touch touch = Input.GetTouch(i);
                if (this.GetComponent<GUITexture>().HitTest(touch.position))
                {
                    hold = true;
                    if (!issplit)
                    {
                        GameObject clone = (GameObject)Instantiate(Clone, drop.transform.position + new Vector3(10, 0, 0), Quaternion.identity);
                        issplit = true;
                    }
                }
                else
                    hold = false;
            }
        }
    }
}

