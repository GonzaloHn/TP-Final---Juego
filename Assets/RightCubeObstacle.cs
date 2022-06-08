using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCubeObstacle : MonoBehaviour
{
    public float movementSpeed;

    public float reloadTime;
    float currTime;
    bool goes;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(5, 8, -30); //lega a 40
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.localScale = new Vector3(10, 10, 10);

        rb = GetComponent<Rigidbody>();
        goes = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (currTime > 0)
        {
            currTime -= Time.deltaTime;
            Debug.Log(reloadTime);
        }
        if (currTime <= 0 && !goes && transform.position.z <= 40)
        {
            rb.velocity = new Vector3(0, 0, 1) * movementSpeed;
            currTime = reloadTime;
            goes = true;
        }
        if (currTime <= 0 && goes)
        {
            rb.velocity = new Vector3(0, 0, 1) * -movementSpeed;
            currTime = reloadTime;
            goes = false;
        }
    }
}
