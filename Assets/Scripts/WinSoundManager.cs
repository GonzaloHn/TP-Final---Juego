using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSoundManager : MonoBehaviour
{
    public AudioClip winSound;
    private AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.clip = winSound;
        m_AudioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
