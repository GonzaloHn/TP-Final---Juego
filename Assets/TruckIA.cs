using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckIA : MonoBehaviour
{
    public float movementSpeed;

    public GameObject player;
    public bool playerIsOnPlatform = false;

    public int xPos;
    public int zPos;
    public int platformAmount;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //while(platformAmount < 6)
        //{

        //    xPos = Random.Range(1, 10);
        //    zPos = Random.Range(1, 10);
        //    Vector3 platformPosition = new Vector3(xPos, 4.4f, zPos);
        //    Instantiate();
        //}
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ////transform.Translate(movementSpeed, 0, 0);
        //rb.velocity = new Vector3(1, 0, 0) * movementSpeed;

        //if (playerIsOnPlatform)
        //{
        //    //player.transform.SetParent(transform);
        //    player.GetComponent<Rigidbody>().velocity = rb.velocity;
        //}
        //else
        //{
        //    player.transform.SetParent(null);
        //}
    }
    
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name == "RigidBodyFPSController")
    //    {
    //        playerIsOnPlatform = true;
    //    }
    //}

    //void OnCollisionExit(Collision collision)
    //{
    ////    if (collision.gameObject.name == "RigidBodyFPSController")
    ////    {
    ////        playerIsOnPlatform = false;
    ////    }

    //    if(collision.gameObject.name == "Goal")
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    /*public GameObject Bullet;
     public Transform BulletSpawn;
     public float reloadTime;
     float currReloadTime;
     bool canShoot = True;
     void Start(){
     currReloadTime = reloadTime
     }

     void update(){
     if(currReloadTime > 0){
     currReloadTime -= Time.deltaTime;
     Debug.Log(reloadTime);
     }

     if(GetMouseButton(0) && reloadTime <= 0){

     Instantiate(Bullet, BulletSpawn.position, BulletSpawn.rotation);
     currReloadTime = reloadTime;
     }
     Debug.Log()

     
     Esto en el Bullet:
     public float speed;
     public float lifetime;

     void Start(){
     Destroy(gameObject, lifetime)
    }
     void Update(){
     transfomr.position += transform.forward * speed;}
     
     void OnCollisionEnter(){
     Destroy(gameObject);
    }*/
}
