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
        floor.transform.position = new Vector3(-70, 0, 0);
        floor.transform.rotation = Quaternion.Euler(90, 0, 0);
        floor.transform.localScale = new Vector3(400, 130, 1);

        //Transform de Platform
        platform.transform.position = new Vector3(-260, 4, 0);


        rb = GetComponent<Rigidbody>();

        //Platform Prefab
        int platformChance = Random.Range(1, 4);
        for(int i = 0; i <= platformChance; i++)
        {
            if (i == 1)
            {
                Instantiate(platform, new Vector3(-260, 4, 15), platform.transform.rotation);
                Instantiate(platform, new Vector3(-260, 4, -15), platform.transform.rotation);
            }
            if (i == 2)
            {
                Instantiate(platform, new Vector3(-240, 4, 0), platform.transform.rotation);
                Instantiate(platform, new Vector3(-280, 4, 0), platform.transform.rotation);
            }
            if (i == 3)
            {
                Instantiate(platform, new Vector3(-240, 4, 25), platform.transform.rotation);
                Instantiate(platform, new Vector3(-240, 4, -25), platform.transform.rotation);
            }
            if (i == 4)
            {
                Instantiate(platform, new Vector3(-280, 4, -25), platform.transform.rotation);
                Instantiate(platform, new Vector3(-280, 4, 25), platform.transform.rotation);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(-1, 0, 0) * movementSpeed;
        floor.transform.SetParent(this.transform);
        goal.transform.SetParent(this.transform);
    }
}
