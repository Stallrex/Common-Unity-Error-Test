using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{
    public AudioClip backgroundMusic;

    void Update()
    {
        var audio = gameObject.AddComponent<AudioSource>();
        audio.clip = backgroundMusic;
        audio.Play();
    }
}
