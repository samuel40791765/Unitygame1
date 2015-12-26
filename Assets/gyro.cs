using UnityEngine;
using System.Collections;

public class gyro : MonoBehaviour
{
    private bool isHasGyro = false;
    private float velo;
    Vector3 force;
    float x;
    float y;
    float z;
    float angle1;
    float angle2;
    // Use this for initialization
    void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            Input.gyro.enabled = true;
            isHasGyro = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        velo = (this.GetComponent<Rigidbody>().velocity.x) * (this.GetComponent<Rigidbody>().velocity.x) + (this.GetComponent<Rigidbody>().velocity.z) * (this.GetComponent<Rigidbody>().velocity.z);
        if (velo <= 500)
        {
            if (isHasGyro && !destination.AtEnd)
            {
                x = Input.gyro.attitude.x;
                y = Input.gyro.attitude.y;
                z = Input.gyro.attitude.z;
                force = new Vector3(-x * 500F, 0.0F, -y * 500F);
            }
            else if (!destination.AtEnd)
            {
                x = Input.acceleration.x;
                y = Input.acceleration.y;
                z = Input.acceleration.z;
                force = new Vector3(-x * 500F, 0.0F, -y * 500F);
            }
            this.GetComponent<Rigidbody>().AddForce(force);
        }
        if (velo >= 500)
        {
            if (isHasGyro && !destination.AtEnd)
            {
                x = Input.gyro.attitude.x;
                y = Input.gyro.attitude.y;
                z = Input.gyro.attitude.z;
            }
            else if (!destination.AtEnd)
            {
                x = Input.acceleration.x;
                y = Input.acceleration.y;
                z = Input.acceleration.z;
            }
            float angle = ((this.GetComponent<Rigidbody>().velocity.x * -x) + (this.GetComponent<Rigidbody>().velocity.z * -y)) / (Mathf.Sqrt((this.GetComponent<Rigidbody>().velocity.x) * (this.GetComponent<Rigidbody>().velocity.x) + (this.GetComponent<Rigidbody>().velocity.z) * (this.GetComponent<Rigidbody>().velocity.z)) * Mathf.Sqrt(x * x + y * y));
            if (angle <= 0)
            {
                force = new Vector3(-x * 500F, 0.0F, -y * 500F);
                this.GetComponent<Rigidbody>().AddForce(force);
            }
            else if (angle > 0)
            {
                angle1 = ((-this.GetComponent<Rigidbody>().velocity.z * -x) + (this.GetComponent<Rigidbody>().velocity.x * -y)) / (Mathf.Sqrt((this.GetComponent<Rigidbody>().velocity.x) * (this.GetComponent<Rigidbody>().velocity.x) + (this.GetComponent<Rigidbody>().velocity.z) * (this.GetComponent<Rigidbody>().velocity.z)) * Mathf.Sqrt(x * x + y * y));
                angle2 = ((this.GetComponent<Rigidbody>().velocity.z * -x) + (-this.GetComponent<Rigidbody>().velocity.x * -y)) / (Mathf.Sqrt((this.GetComponent<Rigidbody>().velocity.x) * (this.GetComponent<Rigidbody>().velocity.x) + (this.GetComponent<Rigidbody>().velocity.z) * (this.GetComponent<Rigidbody>().velocity.z)) * Mathf.Sqrt(x * x + y * y));
                float uva1x = (-this.GetComponent<Rigidbody>().velocity.z) / (Mathf.Sqrt((this.GetComponent<Rigidbody>().velocity.x) * (this.GetComponent<Rigidbody>().velocity.x) + (this.GetComponent<Rigidbody>().velocity.z) * (this.GetComponent<Rigidbody>().velocity.z)));
                float uva1y = (this.GetComponent<Rigidbody>().velocity.x) / (Mathf.Sqrt((this.GetComponent<Rigidbody>().velocity.x) * (this.GetComponent<Rigidbody>().velocity.x) + (this.GetComponent<Rigidbody>().velocity.z) * (this.GetComponent<Rigidbody>().velocity.z)));
                float uva2x = -uva1x;
                float uva2y = -uva1y;

                if (angle1 > 0 && angle2 < 0)
                {
                    force = new Vector3(Mathf.Sqrt(x * x + y * y) * angle1 * uva1x*500F, 0, Mathf.Sqrt(x * x + y * y) * angle1 * uva1y*500F);
                    this.GetComponent<Rigidbody>().AddForce(force);
                }
                else if (angle1 < 0 && angle2 > 0)
                {
                    force = new Vector3(Mathf.Sqrt(x * x + y * y) * angle2 * uva2x*500F, 0, Mathf.Sqrt(x * x + y * y) * angle2 * uva2y*500F);
                    this.GetComponent<Rigidbody>().AddForce(force);
                }
            }

        }
        print(angle1);

    }
}
