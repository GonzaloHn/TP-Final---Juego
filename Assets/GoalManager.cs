using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Funciona");
        if (other.gameObject.name == "RigidBodyFPSController")
        {
            Debug.Log("Traspasa");
            //Destroy(other.gameObject);
        }
    }
}
