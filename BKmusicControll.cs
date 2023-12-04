using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BKmusicControll : MonoBehaviour
{
    public AudioSource BKMusic = null;
    bool IsBKPlaying = true;
    // Start is called before the first frame update
    void Start()
    {
        BKMusic.Play();
        IsBKPlaying = true;
    }

    public void PlayBKMusic()
    {
        BKMusic.Play();
        IsBKPlaying = true;
    }

    public void StopBKMusic()
    {
        BKMusic.Stop();
        IsBKPlaying = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        float r = UnityEngine.Random.Range(0f, 1f);
        float g = UnityEngine.Random.Range(0f, 1f);
        float b = UnityEngine.Random.Range(0f, 1f);
        Color new_color = new Color(r, g, b);
        GetComponent<Renderer>().material.color = new_color;

        if (IsBKPlaying)
        {
            StopBKMusic();
        }
        else
        {
            PlayBKMusic();
        }
    }
}