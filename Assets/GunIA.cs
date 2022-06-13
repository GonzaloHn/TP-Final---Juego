using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunIA : MonoBehaviour
{
    public Transform target;

    public GameObject Bullet;
    public Transform BulletSpawn;

    public float reloadTime;
    float currTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currTime > 0)
        {
            currTime -= Time.deltaTime;
            Debug.Log(reloadTime);
        }

        Vector3 targetOrientation = target.position - transform.position;
        Debug.DrawRay(transform.position, targetOrientation, Color.green);

        Quaternion targetOrientationQuanternion = Quaternion.LookRotation(targetOrientation);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetOrientationQuanternion, Time.deltaTime);

        if (currTime <= 0)
        {
            Instantiate(Bullet, BulletSpawn.position, BulletSpawn.rotation);
            currTime = reloadTime;
        }
    }
}
