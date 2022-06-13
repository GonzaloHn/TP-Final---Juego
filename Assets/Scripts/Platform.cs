using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.name == "Platform")
        //{
        //    Destroy(gameObject);

        //    float xPos = Random.Range(-220, -101);
        //    float zPos = Random.Range(-4, 4);
        //    Vector3 platformPosition = new Vector3(xPos, 4, zPos);

        //    Instantiate(gameObject, platformPosition, gameObject.transform.rotation);
        //}
    }
}
