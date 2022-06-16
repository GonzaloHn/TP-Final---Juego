using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RightCubeObstacle : MonoBehaviour
{
    public float movementSpeed;
    public float gameMotorSpeed;

    public float reloadTime;
    float currTime;
    bool goes;

    Rigidbody rb;

    public float pushPower = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(5, 9, -70); 
        //transform.rotation = Quaternion.Euler(0, 0, 0);
        //transform.localScale = new Vector3(10, 10, 10);

        rb = GetComponent<Rigidbody>();
        goes = false;

        currTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currTime > 0)
        {
            currTime -= Time.deltaTime;
        }
        if (currTime <= 0 && !goes)
        {
            if (transform.position.z <= 70)
            {
                rb.velocity = new Vector3(-1 * gameMotorSpeed, 0, 1 * movementSpeed);
            }
            else
            {
                rb.velocity = new Vector3(-1 * gameMotorSpeed, 0, 0);
                currTime = reloadTime;
                goes = true;
            }
        }
        if (currTime <= 0 && goes)
        {
            if (transform.position.z >= -70)
            {
                rb.velocity = new Vector3(-1 * gameMotorSpeed, 0, 1 * -movementSpeed);
            }
            else
            {
                rb.velocity = new Vector3(-1 * gameMotorSpeed, 0, 0);
                currTime = reloadTime;
                goes = false;
            }
        }
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "FPSController")
        {
            SceneManager.LoadScene("LostScene");

        }
    }
}
