using UnityEngine;
using System.Collections;

public class treemove : MonoBehaviour
{
    Vector3 initial_pos;
    Vector3 recent_pos;
    float timer = 0;
    // Use this for initialization
    void Start()
    {
        initial_pos = this.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        recent_pos.x = initial_pos.x;
        recent_pos.y = initial_pos.y;
        recent_pos.z = initial_pos.z + Mathf.Sin(timer * 2)*7;
        this.transform.localPosition= recent_pos;
    }
}
