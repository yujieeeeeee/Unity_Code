using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endchangeVideo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("GoVideo"))
        {
            SceneManager.LoadScene(collision.gameObject.GetComponent<SceneInfo>().SceneName);
        }
    }
}
