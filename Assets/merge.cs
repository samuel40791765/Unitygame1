using UnityEngine;
using System.Collections;

public class merge : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.name == "drop"&&split.mouse==true)
        {
            Destroy(gameObject);
            Debug.Log("destroy");
            split.issplit = false;
        }
      
    }
}

