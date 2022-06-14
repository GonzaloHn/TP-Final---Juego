using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
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
        if (collision.gameObject.name == "Floor")
        {
            //m_AudioSource.clip = deathSound;
            //m_AudioSource.Play();
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Goal")
        {
            //m_AudioSource.clip = winSound;
            //m_AudioSource.Play();
            Destroy(gameObject);
        }
        if (collision.gameObject.name == "Bullet")
        {
            //m_AudioSource.clip = deathSound;
            //m_AudioSource.Play();
            Destroy(gameObject);
        }
    }
}
