using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMotor : MonoBehaviour
{
    public float movementSpeed;

    public GameObject floor;
    public GameObject goal;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(1, 0, 0) * -movementSpeed;
        floor.transform.SetParent(this.transform);
        goal.transform.SetParent(this.transform);
    }
}
