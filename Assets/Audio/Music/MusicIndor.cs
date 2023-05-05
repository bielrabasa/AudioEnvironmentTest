using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicIndor : MonoBehaviour
{
    public AudioClip[] musicHouse;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

       void OnTriggerEnter(Collider collider)
    {
        if (musicHouse.Length > 0 && !audioSource.isPlaying)
            audioSource.PlayOneShot(musicHouse[Random.Range(0, musicHouse.Length)]);
    }

        void OnTriggerExit(Collider collider)
    {
        if (musicHouse.Length > 0 && audioSource.isPlaying)
            audioSource.Pause();
    }
}
