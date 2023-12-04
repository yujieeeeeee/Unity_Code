using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ans : MonoBehaviour
{
    public Image 小新;
    public Image 小新2;
    public Image Q1;
    public Image Q2;
    public Image Q3;
    public Image Q4;
    public Text Score;
    public AudioSource SoundEffect;
    public AudioClip[] Soundclips;
    private int score = 0;
    public Image scores;
    public Image end;
    public string[] EndDialog;
    public string[] LoseDialog;
    public Text end1;
    public Text end2;
    
    public Image win;
    public Image lose;
    public Button EntireBotton;
    public Image 小新no;
    // Start is called before the first frame update
    IEnumerator Next()
    {
        小新.enabled = true;
        小新2.enabled = false;
        yield return new WaitForSeconds(2f);
        Q2.gameObject.SetActive(true);
        Q1.gameObject.SetActive(false);
        小新.enabled = false;
        小新2.enabled = true;
        scores.gameObject.SetActive(true);
    }
    IEnumerator Next2()
    {
        小新.enabled = true;
        小新2.enabled = false;
        yield return new WaitForSeconds(2f);
        Q3.gameObject.SetActive(true);
        Q2.gameObject.SetActive(false);
        小新.enabled = false;
        小新2.enabled = true;
    }
    IEnumerator Next3()
    {
        小新.enabled = true;
        小新2.enabled = false;
        yield return new WaitForSeconds(2f);
        Q4.gameObject.SetActive(true);
        Q3.gameObject.SetActive(false);
        小新.enabled = false;
        小新2.enabled = true;
    }
    IEnumerator Next4()
    {
        小新.enabled = true;
        小新2.enabled = false;
        yield return new WaitForSeconds(2f);
        Q4.gameObject.SetActive(false);
        小新.enabled = false;
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
    {   lose.enabled = true;
        end.gameObject.SetActive(true);
        foreach (string sen in LoseDialog)
        {
            end2.text = sen;
            yield return new WaitForSeconds(2f);
        }
        EntireBotton.gameObject.SetActive(true);

    }
    public void ButtonYes()
    {
        StartCoroutine(Next());
        score += 25;
        Score.text = score.ToString();
        PlayWinSound();
    }
    public void ButtonYes2()
    {
        StartCoroutine(Next2());
        score += 25;
        Score.text = score.ToString();
        PlayWinSound();
    }
    public void ButtonYes3()
    {
        StartCoroutine(Next3());
        score += 25;
        Score.text = score.ToString();
        PlayWinSound();
    }
    public void ButtonYes4()
    {
        StartCoroutine(Next4());
        score += 25;
        Score.text = score.ToString();
        PlayWinSound();
    }
    IEnumerator Nextt()
    {
        小新no.enabled = true;
        小新2.enabled = false;
        yield return new WaitForSeconds(2f);
        Q2.gameObject.SetActive(true);
        Q1.gameObject.SetActive(false);
        小新no.enabled = false;
        小新2.enabled = true;
    }
    IEnumerator Nextt2()
    {
        小新no.enabled = true;
        小新2.enabled = false;
        yield return new WaitForSeconds(2f);
        Q3.gameObject.SetActive(true);
        Q2.gameObject.SetActive(false);
        小新no.enabled = false;
        小新2.enabled = true;
    }
    IEnumerator Nextt3()
    {
        小新no.enabled = true;
        小新2.enabled = false;
        yield return new WaitForSeconds(2f);
        Q4.gameObject.SetActive(true);
        Q3.gameObject.SetActive(false);
        小新no.enabled = false;
        小新2.enabled = true;
    }
    IEnumerator Nextt4()
    {
        小新no.enabled = true;
        小新2.enabled = false;
        yield return new WaitForSeconds(2f);
        Q4.gameObject.SetActive(false);
        小新no.enabled = false;
        if (score > 60)
        {
            StartCoroutine(Win());
        }
        else
        {
            StartCoroutine(Lose());
        }
    }

    void Start()
    {
        
        Q2.gameObject.SetActive(false);
        Q3.gameObject.SetActive(false);
        Q4.gameObject.SetActive(false);
        小新.enabled = false;
        小新no.enabled = false;
        score = 0;

        Score.text = score.ToString();
        end.gameObject.SetActive(false);
        win.enabled = false;
        lose.enabled = false;
        EntireBotton.gameObject.SetActive(false);


    }
    public void ButtonNo()
    {
        StartCoroutine(Nextt());
        PlayLoseSound();
    }

    public void ButtonNo2()
    {
        StartCoroutine(Nextt2());
        PlayLoseSound();
    }
    public void ButtonNo3()
    {
        StartCoroutine(Nextt3());
        PlayLoseSound();
    }
    public void ButtonNo4()
    {
        StartCoroutine(Nextt4());
        PlayLoseSound();
    }
    void PlayWinSound()
    {
        SoundEffect.clip = Soundclips[0];
        SoundEffect.Play();
    }
    void PlayLoseSound()
    {
        SoundEffect.clip = Soundclips[1];
        SoundEffect.Play();
    }
    public void ChangeS2()
    {
        SceneManager.LoadScene(3);
    }



    // Update is called once per frame
    void Update()
    {

    }
}
