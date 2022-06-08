using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMotor : MonoBehaviour
{
    public float movementSpeed;

    public GameObject floor;
    public GameObject goal;

    public GameObject leftCube;
    public GameObject rightCube;

    Rigidbody rb;

    public int xPos;
    public int zPos;
    public int platformAmount;
    public GameObject platform;

    // Start is called before the first frame update
    void Start()
    {
        //Transform de Floor
        floor.transform.position = new Vector3(0, 0, 0);
        floor.transform.rotation = Quaternion.Euler(0, 90, 0);
        floor.transform.localScale = new Vector3(5.795128f, 1, 23.61662f);

        //Transform de Goal
        goal.transform.position = new Vector3(115, 38.1f, 0);
        goal.transform.rotation = Quaternion.Euler(0, 0, 0);
        goal.transform.localScale = new Vector3(1.264f, 68.51382f, 99.93681f);

        //Transform de Platform
        platform.transform.position = new Vector3(-108.8f, 4, 0);
        platform.transform.rotation = Quaternion.Euler(0, 0, 0);
        platform.transform.localScale = new Vector3(8.9907f, 0.5111f, 4.3213f);



        rb = GetComponent<Rigidbody>();

        //Platform Prefab
       //for(int i = 0; i<platformAmount; i++)
       //{
       //     xPos = Random.Range(-21, -1);
       //     zPos = Random.Range(-21, -1);
       //     Vector3 platformPosition = new Vector3(xPos, 3.0f, zPos);

       //     Instantiate(platform, platformPosition, platform.transform.rotation);
       //}
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(1, 0, 0) * -movementSpeed;
        floor.transform.SetParent(this.transform);
        goal.transform.SetParent(this.transform);
        //leftCube.transform.SetParent(this.transform);
        //rightCube.transform.SetParent(this.transform);
    }
}
