using UnityEngine;
using System.Collections;

public class gyro : MonoBehaviour
{

    public GameObject healanim;
    private bool isHasGyro = false;
    private float velo;
    private float control;
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

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
        healanim.SetActive(false);
    }

	void OnGUI(){
		//GUI.Label (new Rect (50, 50, 300, 50),"x= " +x +" y=" +y + " z" +z );
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
                control = x * x + y * y + z * z;
                if (control > 50)
                    force = new Vector3(-x * 800F, 0.0F, -y * 800F);
                else
                    force = new Vector3(-x * 200F, 0.0F, -y * 200F);
            }
            else if (!destination.AtEnd)
            {
                x = Input.acceleration.x;
                y = Input.acceleration.y;
                z = Input.acceleration.z;
                control = x * x + y * y + z * z;
                if (control > 50)
                    force = new Vector3(-x * 800F, 0.0F, -y * 800F);
                else
                    force = new Vector3(-x * 200F, 0.0F, -y * 200F);
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
                control = x * x + y * y + z * z;
            }
            else if (!destination.AtEnd)
            {
                x = Input.acceleration.x;
                y = Input.acceleration.y;
                z = Input.acceleration.z;
                control = x * x + y * y + z * z;
            }
            float angle = ((this.GetComponent<Rigidbody>().velocity.x * -x) + (this.GetComponent<Rigidbody>().velocity.z * -y)) / (Mathf.Sqrt((this.GetComponent<Rigidbody>().velocity.x) * (this.GetComponent<Rigidbody>().velocity.x) + (this.GetComponent<Rigidbody>().velocity.z) * (this.GetComponent<Rigidbody>().velocity.z)) * Mathf.Sqrt(x * x + y * y));
            if (angle <= 0)
            {
                if (control > 50)
                    force = new Vector3(-x * 800F, 0.0F, -y * 800F);
                else
                    force = new Vector3(-x * 200F, 0.0F, -y * 200F);
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
                    if (control > 50)
                        force = new Vector3(Mathf.Sqrt(x * x + y * y) * angle1 * uva1x * 800F, 0, Mathf.Sqrt(x * x + y * y) * angle1 * uva1y * 800F);
                    else
                        force = new Vector3(Mathf.Sqrt(x * x + y * y) * angle1 * uva1x * 200F, 0, Mathf.Sqrt(x * x + y * y) * angle1 * uva1y * 200F);
                    this.GetComponent<Rigidbody>().AddForce(force);
                }
                else if (angle1 < 0 && angle2 > 0)
                {
                    if (control > 50)
                        force = new Vector3(Mathf.Sqrt(x * x + y * y) * angle2 * uva2x * 800F, 0, Mathf.Sqrt(x * x + y * y) * angle2 * uva2y * 800F);
                    else
                        force = new Vector3(Mathf.Sqrt(x * x + y * y) * angle2 * uva2x * 200F, 0, Mathf.Sqrt(x * x + y * y) * angle2 * uva2y * 200F);
                    this.GetComponent<Rigidbody>().AddForce(force);
                }
            }

        }

		if (healanim.activeSelf) {
			StartCoroutine(Wait ());
		}
    }
}

		