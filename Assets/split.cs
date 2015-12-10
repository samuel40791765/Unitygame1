using UnityEngine;
using System.Collections;

public class split : MonoBehaviour
{
    public GameObject drop;
    public GameObject Clone;
    public static bool issplit = false;
    public static bool mouse = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        mouse = true;
        if (!issplit)
        {
            GameObject clone = (GameObject)Instantiate(Clone, drop.transform.position + new Vector3(10, 0, 0), Quaternion.identity);
            issplit = true;
        }
    }
void OnMouseExit()
    {
        mouse = false;
    }
}

