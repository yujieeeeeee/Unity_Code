using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Videotalk : MonoBehaviour
{
    public string[] StartDialog;
    public Text Dialog;
    public Image main;
    public Image shin;



    private IEnumerator StartChat()
    {

        foreach (string sen in StartDialog)
        {
            Dialog.text = sen;
            yield return new WaitForSeconds(3f);
        }

        main.enabled = false;
        Dialog.enabled = false;
        shin.enabled = false;
        SceneManager.LoadScene(7);

    }
    // Start is called before the first frameupdate
    void Start()
    {
        


        StartCoroutine(StartChat());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
