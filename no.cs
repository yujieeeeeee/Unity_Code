using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class no : MonoBehaviour
{
    
    public Image �p�sno;
    public Image �p�s;
    public Image Q1;
    public Image Q2;
    public Image Q3;
    public Image Q4;
    public AudioSource SoundEffect;
    public AudioClip Soundclips;
    public Image end;
    public Text end1;
    public Text end2;
    public string[] EndDialog;
    public string[] LoseDialog;
    public Image win;
    public Image lose;
    public Button EntireBotton;
    public int score = 0;
    public Image scores;
    public Text Score;
    // Start is called before the first frame update
    IEnumerator Next()
    {
        �p�sno.enabled = true;
        �p�s.enabled = false;
        yield return new WaitForSeconds(2f);
        Q2.gameObject.SetActive(true);
        Q1.gameObject.SetActive(false);
        �p�sno.enabled = false;
        �p�s.enabled = true;
    }
    IEnumerator Next2()
    {
        �p�sno.enabled = true;
        �p�s.enabled = false;
        yield return new WaitForSeconds(2f);
        Q3.gameObject.SetActive(true);
        Q2.gameObject.SetActive(false);
        �p�sno.enabled = false;
        �p�s.enabled = true;
    }
    IEnumerator Next3()
    {
        �p�sno.enabled = true;
        �p�s.enabled = false;
        yield return new WaitForSeconds(2f);
        Q4.gameObject.SetActive(true);
        Q3.gameObject.SetActive(false);
        �p�sno.enabled = false;
        �p�s.enabled = true;
    }
    IEnumerator Next4()
    {
        �p�sno.enabled = true;
        �p�s.enabled = false;
        yield return new WaitForSeconds(2f);
        Q4.gameObject.SetActive(false);
        �p�sno.enabled = false;
        if (score > 60)
        {
            StartCoroutine(Win());
        }
        else
        {
            StartCoroutine(Lose());
        }
    }
    private IEnumerator Win()
    {
        win.enabled = true;
        end.gameObject.SetActive(true);

        foreach (string sen in EndDialog)
        {
            end1.text = sen;
            yield return new WaitForSeconds(2f);
        }
        EntireBotton.gameObject.SetActive(true);

    }
    private IEnumerator Lose()
    {
        lose.enabled = true;
        end.gameObject.SetActive(true);
        foreach (string sen in LoseDialog)
        {
            end2.text = sen;
            yield return new WaitForSeconds(2f);
        }
        EntireBotton.gameObject.SetActive(true);

    }
    public void ButtonNo()
    {
        StartCoroutine(Next());
        PlayLoseSound();
    }
    
    public void ButtonNo2()
    {
        StartCoroutine(Next2());
        PlayLoseSound();
    }
    public void ButtonNo3()
    {
        StartCoroutine(Next3());
        PlayLoseSound();
    }
    public void ButtonNo4()
    {
        StartCoroutine(Next4());
        PlayLoseSound();
    }
    void Start()
    {

        Q2.gameObject.SetActive(false);
        Q3.gameObject.SetActive(false);
        Q4.gameObject.SetActive(false);
        �p�sno.enabled = false;
        end.gameObject.SetActive(false);

    }
    void PlayLoseSound()
    {
        SoundEffect.clip = Soundclips;
        SoundEffect.Play();
    }
        // Update is called once per frame
        void Update()
    {

    }
}
