using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed;
    }
    //void OnCollisionEnter(Collision other)
    //{
    //    if (other.gameObject.name == "FPSController")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
}
