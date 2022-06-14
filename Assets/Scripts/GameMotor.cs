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
        //int initialLeftCubePosition = 15;
        //int initialRightCubePosition = 5;
        //for (int i = 0; i < 1; i++)
        //{
        //    Vector3 leftCubePosition = new Vector3(15, 8, 70);
        //    Instantiate(leftCube, leftCubePosition, leftCube.transform.rotation);

        //    Vector3 rightCubePosition = new Vector3(5, 8, -70);
        //    Instantiate(rightCube, rightCubePosition, rightCube.transform.rotation);
            
        //    initialLeftCubePosition = initialLeftCubePosition - 40;
        //    initialRightCubePosition = initialRightCubePosition - 40;
        //}
        //for (int i = 0; i < 2; i++)
        //{
        //    int chance = Random.Range(1, 3);
        //    switch (chance)
        //    {
        //        case 1:
        //            Instantiate(leftCube, new Vector3(8, -45, 70), leftCube.transform.rotation);
        //            Instantiate(rightCube, new Vector3(-55, 8, 70), rightCube.transform.rotation);
        //            break;
        //        case 2:
        //            Instantiate(leftCube, new Vector3(8, -105, 70), leftCube.transform.rotation);
        //            Instantiate(rightCube, new Vector3(-115, 8, 70), rightCube.transform.rotation);
        //            break;
        //        case 3:
        //            Instantiate(leftCube, new Vector3(8, -170, 70), leftCube.transform.rotation);
        //            Instantiate(rightCube, new Vector3(-185, 8, 70), rightCube.transform.rotation);
        //            break;
        //        default:
        //            break;

        //    }
        //}
        //int chance = Random.Range(1, 10);
        //if (chance < 10)
        //{
        //    Vector3 leftCubePosition = new Vector3(-30, 10, 70);
        //    Instantiate(leftCube, leftCubePosition, leftCube.transform.rotation);

        //    int secondChance = Rnadom.Range(1, 5)
        //    if (secondChance == 1)
        //    {
        //        gunPosition = new Vector3(40, 10, 70);
        //        Instantiate(gameObject, gunPosition, transform.rotation);

        //        gunPosition = new Vector3(40, 10, -100);
        //        Instantiate(gameObject, gunPosition, transform.rotation);
        //    }
        //}



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
        rb.velocity = new Vector3(-1, 0, 0) * movementSpeed;
        floor.transform.SetParent(this.transform);
        goal.transform.SetParent(this.transform);
    }
}
