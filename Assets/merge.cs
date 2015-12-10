using UnityEngine;
using System.Collections;

public class merge : MonoBehaviour
{
    public GameObject drop;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision drop)
    {
        Destroy(this);
    }
}

