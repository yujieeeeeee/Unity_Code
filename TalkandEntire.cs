using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TalkandEntire : MonoBehaviour
{
    
    public string[] StartDialog;
    public Text Dialog;
    public Image main;
    public Button EntireBotton;
    

    private IEnumerator StartChat()
    {

        foreach (string sen in StartDialog)
        {
            Dialog.text = sen;
            yield return new WaitForSeconds(3f);
        }
        
        main.enabled = false;
        Dialog.enabled = false;
        EntireBotton.gameObject.SetActive(true);

    }
    // Start is called before the first frameupdate
    void Start()
    {
        EntireBotton.gameObject.SetActive(false);
        
        
        StartCoroutine(StartChat());
    }

    // Update is called once per frame
    void Update()
    {

    }
}
