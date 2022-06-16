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

        //Transform de Goal
        goal.transform.position = new Vector3(110, 33, 0);
        goal.transform.rotation = Quaternion.Euler(0, 0, 90);
        goal.transform.localScale = new Vector3(63, 3, 130);

        //Transform de Platform
        platform.transform.position = new Vector3(-260, 4, 0);
        platform.transform.rotation = Quaternion.Euler(0, 0, 0);
        platform.transform.localScale = new Vector3(9, 0.5f, 4.5f);

        //Instantiate de Cubes

        //int cubeChance = Random.Range(1, 5);
        //switch (cubeChance)
        //{
        //    case 1:
        //        Instantiate(leftCube, new Vector3(-50, 5, 70), leftCube.transform.rotation);
        //        Instantiate(rightCube, new Vector3(-40, 5, -70), rightCube.transform.rotation);
        //        break;
        //    case 2:
        //        Instantiate(leftCube, new Vector3(-70, 5, 70), leftCube.transform.rotation);
        //        Instantiate(rightCube, new Vector3(-60, 5, -70), rightCube.transform.rotation);
        //        break;
        //    case 3:
        //        Instantiate(leftCube, new Vector3(-120, 5, 70), leftCube.transform.rotation);
        //        Instantiate(rightCube, new Vector3(-90, 5, -70), rightCube.transform.rotation);
        //        break;
        //    case 4:
        //        Instantiate(leftCube, new Vector3(-170, 5, 70), leftCube.transform.rotation);
        //        Instantiate(rightCube, new Vector3(-150, 5, -70), rightCube.transform.rotation);
        //        break;
        //    case 5:
        //        Instantiate(leftCube, new Vector3(-210, 5, 70), leftCube.transform.rotation);
        //        Instantiate(rightCube, new Vector3(-190, 5, -70), rightCube.transform.rotation);
        //        break;
        //    default:
        //        break;

        //}

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
