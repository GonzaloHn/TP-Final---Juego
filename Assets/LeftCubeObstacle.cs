using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCubeObstacle : MonoBehaviour
{
    public float movementSpeed;

    public float reloadTime;
    float currTime;
    bool goes;

    Rigidbody rb;

    public float pushPower = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(15.3f, 6, 75); //llega a -70
        transform.rotation = Quaternion.Euler(0, 0, 0);
        transform.localScale = new Vector3(10, 10, 10);

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
            Debug.Log(reloadTime);
        }
        if (currTime <= 0 && !goes)
        {
            if(transform.position.z >= -70)
            {
            rb.velocity = new Vector3(0, 0, 1) * -movementSpeed;
            }
            else
            {
                rb.velocity = new Vector3(0, 0, 0);
                currTime = reloadTime;
                goes = true;
            }
        }
        if (currTime <= 0 && goes)
        {
            if(transform.position.z <= 75)
            {
                rb.velocity = new Vector3(0, 0, 1) * movementSpeed;
            }
            else
            {
                rb.velocity = new Vector3(0, 0, 0);
                currTime = reloadTime;
                goes = false;
            }
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic)
        {
            return;
        }
        if (hit.moveDirection.y < -0.3)
        {
            return;
        }

        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);

        body.velocity = pushDir * pushPower;
    }
}
