using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckIA : MonoBehaviour
{
    public float movementSpeed;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, movementSpeed);
    }
    
    void OnCollisionStay(Collision collision)
    {

        if (collision.gameObject.name == "Prueba")
        {
            player.transform.Translate(0, 0, movementSpeed);
       }
    }
}
