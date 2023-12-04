using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feet : MonoBehaviour
{
    public Animator GetA;
    public AudioSource GetAudioSource;

    void Start()
    {
        GetA = this.GetComponent<Animator>();
        GetAudioSource = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (GetA.GetFloat("InputVertical") >= 0.4f)
        {
            if (!GetAudioSource.isPlaying)
                GetAudioSource.Play();
        }
        else
        {
            GetAudioSource.Stop();
        }
    }
}
