using UnityEngine;
using System.Collections;

public class split : MonoBehaviour
{
    public GameObject drop;
    public GameObject Clone;
    private bool issplit = false;
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
        if (!issplit)
        {
            GameObject clone = (GameObject)Instantiate(Clone);
            clone.transform.position = drop.transform.position + new Vector3(5, 0, 0);
            issplit = true;
        }
    }

}

