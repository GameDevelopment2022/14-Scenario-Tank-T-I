using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class objectdamage : MonoBehaviour
{
    public GameObject thunderimg, nearbarrier, farbarrier, nopanel,yespanel,crane;
    void Start()
    {
        Invoke("thunderimgactive", 3.0f);
    }

  public void thunderimgactive()
    {
        thunderimg.SetActive(true);

    }

    public void no()
    {
        thunderimg.SetActive(false);
        crane.gameObject.GetComponent<Animator>().enabled = true;
        farbarrier.SetActive(true);
        Invoke("notrue", 8.5f);
        // nopanel.SetActive(true);
    }
    public void yes()
    {
        thunderimg.SetActive(false);
        crane.gameObject.GetComponent<Animator>().enabled = true;
        nearbarrier.SetActive(true);
         Invoke("yestrue", 8.5f);

    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
   
   
    public void yestrue()
    {
        yespanel.SetActive(true);
    }
    public void notrue()
    {
        nopanel.SetActive(true);
    }
}
