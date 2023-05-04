using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnvironmentChange : MonoBehaviour
{
    public AudioMixerSnapshot outdoorSnapshot;
    public AudioMixerSnapshot indoorSnapshot;

    public float transitionTime = 0.25f;

    void OnTriggerEnter(Collider collider)
    {
        indoorSnapshot.TransitionTo(transitionTime);
    }
    
    void OnTriggerExit(Collider collider)
    {
        outdoorSnapshot.TransitionTo(transitionTime);
    }
}
