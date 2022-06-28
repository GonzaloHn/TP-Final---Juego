using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    public GameObject gunOne;
    public GameObject gunTwo;
    public GameObject gunThree;
    public GameObject gunFour;
    public GameObject gunFive;
    public GameObject gunSix;

    public GameObject leftCubeOne;
    public GameObject leftCubeTwo;
    public GameObject leftCubeThree;
    public GameObject leftCubeFour;
    public GameObject leftCubeFive;

    public GameObject rightCubeOne;
    public GameObject rightCubeTwo;
    public GameObject rightCubeThree;
    public GameObject rightCubeFour;
    public GameObject rightCubeFive;
    

    // Start is called before the first frame update
    void Start()
    {
        gunOne.transform.position = new Vector3(-40, 10, -100);
        gunTwo.transform.position = new Vector3(-40, 10, 100);
        gunThree.transform.position = new Vector3(-200, 10, -100);
        gunFour.transform.position = new Vector3(-40, 40, -100);
        gunFive.transform.position = new Vector3(-40, 40, 100);
        gunSix.transform.position = new Vector3(-200, 10, 100);

        int chance = Random.Range(0, 5);
        for(int i = 0; i <= chance; i++)
        {
            if (i == 1)
            {
                Destroy(gunSix);
            }
            if (i == 2)
            {
                Destroy(gunFive);
            }
            if (i == 3)
            {
                Destroy(gunFour);
            }
            if (i == 4)
            {
                Destroy(gunThree);
            }
            if (i == 5)
            {
                Destroy(gunTwo);
            }
        }

        leftCubeOne.transform.position = new Vector3(25, 9, 70);
        leftCubeTwo.transform.position = new Vector3(-35, 9, 70);
        leftCubeThree.transform.position = new Vector3(-95, 9, 70);
        leftCubeFour.transform.position = new Vector3(-155, 9, 70);
        leftCubeFive.transform.position = new Vector3(-215, 9, 70);

        rightCubeOne.transform.position = new Vector3(5, 9, -70);
        rightCubeTwo.transform.position = new Vector3(-55, 9, -70);
        rightCubeThree.transform.position = new Vector3(-115, 9, -70);
        rightCubeFour.transform.position = new Vector3(-175, 9, -70);
        rightCubeFive.transform.position = new Vector3(-235, 9, -70);

        int cubeChance = Random.Range(0, 3);
        for (int i = 0; i <= cubeChance; i++)
        {
            if (i == 1)
            {
                Destroy(leftCubeFive);
                Destroy(rightCubeFive);
            }
            if (i == 2)
            {
                Destroy(leftCubeFour);
                Destroy(rightCubeFour);
            }
            if (i == 3)
            {
                Destroy(leftCubeThree);
                Destroy(rightCubeThree);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
