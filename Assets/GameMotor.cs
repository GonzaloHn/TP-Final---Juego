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
        floor.transform.localScale = new Vector3(6, 1, 25);

        //Transform de Goal
        goal.transform.position = new Vector3(122, 33, 0);
        goal.transform.rotation = Quaternion.Euler(0, 0, 90);
        goal.transform.localScale = new Vector3(63, 3, 120);

        //Transform de Platform
        platform.transform.position = new Vector3(-110, 4, 0);
        platform.transform.rotation = Quaternion.Euler(0, 0, 0);
        platform.transform.localScale = new Vector3(9, 0.5f, 4.5f);



        rb = GetComponent<Rigidbody>();

        //Platform Prefab
      for(int i = 0; i<platformAmount; i++)
       {
            xPos = Random.Range(-115, -101);
            zPos = Random.Range(-4, 4);
            Vector3 platformPosition = new Vector3(xPos, 4, zPos);

            Instantiate(platform, platformPosition, platform.transform.rotation); //algo con collision ENter
       }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(1, 0, 0) * -movementSpeed; //transform.translate
        floor.transform.SetParent(this.transform);
        goal.transform.SetParent(this.transform);
        leftCube.transform.SetParent(this.transform);
        //rightCube.transform.SetParent(this.transform);
    }
}
