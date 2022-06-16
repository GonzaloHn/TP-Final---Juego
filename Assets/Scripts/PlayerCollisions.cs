using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisions : MonoBehaviour
{
    [SerializeField] private AudioClip deathSound;
    [SerializeField] private AudioClip winSound;
    private AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision)
    {
        //if (collision.gameObject.name == "Floor")
        //{
        //    //m_AudioSource.clip = deathSound;
        //    //m_AudioSource.Play();
        //    Destroy(gameObject);
        //}
        //if (collision.gameObject.name == "Goal")
        //{
        //    //m_AudioSource.clip = winSound;
        //    //m_AudioSource.Play();
        //    Destroy(gameObject);
        //}
        //if (collision.gameObject.name == "Bullet")
        //{
        //    //m_AudioSource.clip = deathSound;
        //    //m_AudioSource.Play();
        //    Destroy(gameObject);
        //}
        if (collision.gameObject.name == "Floor")
        {
            m_AudioSource.clip = deathSound;
            m_AudioSource.Play();
            SceneManager.LoadScene("LostScene");
        }
        if (collision.gameObject.name == "Goal")
        {
            m_AudioSource.clip = winSound;
            m_AudioSource.Play();
            SceneManager.LoadScene("WinScene");
        }
        if (collision.gameObject.name == "Bullet")
        {
            m_AudioSource.clip = deathSound;
            m_AudioSource.Play();
            SceneManager.LoadScene("LostScene");
        }
        if (collision.gameObject.name == "RightCubeObstacle" || collision.gameObject.name == "LeftCubeObstacule")
        {
            m_AudioSource.clip = deathSound;
            m_AudioSource.Play();
            SceneManager.LoadScene("LostScene");
            Destroy(gameObject);
        }
    }
}
