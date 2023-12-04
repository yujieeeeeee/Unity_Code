using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endtalk : MonoBehaviour
{
    public string[] StartDialog;
    public Text Dialog;
    public Image main;
    


    private IEnumerator StartChat()
    {

        foreach (string sen in StartDialog)
        {
            Dialog.text = sen;
            yield return new WaitForSeconds(2f);
        }

        

    }
    // Start is called before the first frameupdate
    void Start()
    {
        


        StartCoroutine(StartChat());
    }
}
