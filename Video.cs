using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Video : MonoBehaviour
{
    public VideoPlayer vp = null;
    public VideoClip[] vclips = null;
    private int CurrentClipIndex = 0;
    public void Playvideo()
    {
        vp.clip = vclips[CurrentClipIndex];
        vp.Play();
        
    }

    public void Stopvideo()
    {
        vp.Stop();
        
    }

    public void team()
    {
        CurrentClipIndex = 0;
        Playvideo();
        
    }

    public void meet()
    {

        CurrentClipIndex = 1;
        Playvideo();
         
        
    }
    public void mission()
    {

        CurrentClipIndex = 2;
        Playvideo();


    }

    public void ChangeS1()
    {

        SceneManager.LoadScene(1);


    }
}
