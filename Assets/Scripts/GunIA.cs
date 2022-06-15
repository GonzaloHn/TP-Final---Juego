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

    Rigidbody rb;
    public float gameMotorSpeed;

    public AudioClip shoot;
    AudioSource fuenteAudio;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody>();
 
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(-1 * gameMotorSpeed, 0, 0);
        if (currTime > 0)
        {
            currTime -= Time.deltaTime;
        }

        Vector3 targetOrientation = target.position - transform.position;
        Debug.DrawRay(transform.position, targetOrientation, Color.green);

        Quaternion targetOrientationQuanternion = Quaternion.LookRotation(targetOrientation);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetOrientationQuanternion, 100);

        if (currTime <= 0)
        {
            Instantiate(Bullet, BulletSpawn.position, BulletSpawn.rotation);
            currTime = reloadTime;
            fuenteAudio.clip = shoot;
            fuenteAudio.Play();
        }
    }
}
