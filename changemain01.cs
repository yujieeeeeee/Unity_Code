using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changemain01 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Gomain01"))
        {
            SceneManager.LoadScene(collision.gameObject.GetComponent<SceneInfo>().SceneName);
        }
    }
}
