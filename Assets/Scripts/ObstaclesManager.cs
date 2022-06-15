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


    // Start is called before the first frame update
    void Start()
    {
        gunOne.transform.position = new Vector3(-30, 10, -100);
        gunTwo.transform.position = new Vector3(-30, 10, 100);
        gunThree.transform.position = new Vector3(-200, 10, -100);
        gunFour.transform.position = new Vector3(-30, 40, -100);
        gunFive.transform.position = new Vector3(-30, 40, 100);
        gunSix.transform.position = new Vector3(-200, 10, 100);

        int chance = Random.Range(1, 5);
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
