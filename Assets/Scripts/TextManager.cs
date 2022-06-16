using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public AudioClip deathSound;
    private AudioSource m_AudioSource;
    public Text consejo;
    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        m_AudioSource.clip = deathSound;
        m_AudioSource.Play();
        int chance = Random.Range(1, 5);
        switch (chance)
        {
            case 1:
                consejo.text = "La proxima vez, no lo hagas";
                break;
            case 2:
                consejo.text = "La mejor forma de no perder, es no jugar";
                break;
            case 3:
                consejo.text = "Consejo: Intenta mejorar";
                break;
            case 4:
                consejo.text = "Pésimo";
                break;
            case 5:
                consejo.text = "Para la próxima, no lo hagas tan mal";
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
