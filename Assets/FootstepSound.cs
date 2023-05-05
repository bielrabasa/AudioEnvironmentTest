using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] footstepsOnGrass;
    public AudioClip[] footstepsOnWood;
    public AudioClip[] footstepsOnStone;
    public AudioClip[] footstepsOnDirt;
    public AudioClip[] footstepsOnFlower;
    public AudioClip[] footstepsOnWater;

    public string material;

    void PlayFootstepSound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = Random.Range(0.9f,1.0f);
        audioSource.pitch = Random.Range(0.9f,1.1f);

        switch(material)
        {
            case "Grass":
                if (footstepsOnGrass.Length > 0)
                    audioSource.PlayOneShot(footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)]);
                break;

            case "Wood":
                if (footstepsOnWood.Length > 0)
                    audioSource.PlayOneShot(footstepsOnWood[Random.Range(0, footstepsOnWood.Length)]);
                break;

            case "Stone":
                if (footstepsOnStone.Length > 0)
                    audioSource.PlayOneShot(footstepsOnStone[Random.Range(0, footstepsOnStone.Length)]);
                break;

            case "Dirt":
                if (footstepsOnDirt.Length > 0)
                    audioSource.PlayOneShot(footstepsOnDirt[Random.Range(0, footstepsOnDirt.Length)]);
                break;

            case "Flower":
                if (footstepsOnFlower.Length > 0)
                    audioSource.PlayOneShot(footstepsOnFlower[Random.Range(0, footstepsOnFlower.Length)]);
                break;

            case "Water":
                if (footstepsOnWater.Length > 0)
                    audioSource.PlayOneShot(footstepsOnWater[Random.Range(0, footstepsOnWater.Length)]);
                break;
            default:
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Grass":
            case "Wood":
            case "Stone":
            case "Dirt":
            case "Flower":
            case "Water":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
}
