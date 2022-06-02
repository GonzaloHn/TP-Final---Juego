﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckIA : MonoBehaviour
{
    public float movementSpeed;

    public GameObject player;
    public bool playerIsOnPlatform = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementSpeed, 0, 0);

        if (playerIsOnPlatform)
        {
            player.transform.SetParent(this.transform);
        }
        else
        {
            player.transform.SetParent(null);
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "RigidBodyFPSController")
        {
            playerIsOnPlatform = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "RigidBodyFPSController")
        {
            playerIsOnPlatform = false;
        }

        if(collision.gameObject.name == "Goal")
        {
            Destroy(gameObject);
        }
    }

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
