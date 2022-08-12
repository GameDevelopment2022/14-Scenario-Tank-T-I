using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class managerfor10 : MonoBehaviour
{
    public GameObject cam1, 
        black ,butto;

    public void Start()
    {
       // Invoke("blackactive", 6.0f);
      //  Invoke("playeractive", 7.0f);
    }

    public void blackactive()
    {
        black.SetActive(true);
        butto.SetActive(false);
       Invoke("playeractive", 1.0f);
    }
    public void playeractive()
        {
        SceneManager.LoadScene(4);
        }

}
