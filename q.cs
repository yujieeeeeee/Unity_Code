using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class q : MonoBehaviour
{
    
    public string[] StartDialog;
    public Text Dialog;
    public Image hi;
    public Image Q1;
    public Image Q2;
    public Button A, B, C, D;
    public Image scores;

    public IEnumerator StartChat()
    {

        foreach (string sen in StartDialog)
        {
            Dialog.text = sen;
            yield return new WaitForSeconds(3f);
        }
        Q1.gameObject.SetActive(true);
        hi.enabled = false;
        Dialog.enabled = false;
        scores.gameObject.SetActive(true);


    }
    // Start is called before the first frame update
    void Start()
    {
        
        Q1.gameObject.SetActive(false);
        Q2.gameObject.SetActive(false);
        
        StartCoroutine(StartChat());
        scores.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
