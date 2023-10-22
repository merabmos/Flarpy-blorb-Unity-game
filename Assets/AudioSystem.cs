using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    public AudioSource audioSource;

    public void Start()
    {
        audioSource.Play();
    }
 
    public void StopMusic()
    {
        audioSource.Play();
    }

}
