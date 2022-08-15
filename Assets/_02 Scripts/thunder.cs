using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class thunder : MonoBehaviour
{
    public GameObject thunderimg, bijli1, bijli2, nopanel,yespanel,crane,aag;
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
        nopanel.SetActive(true);
    }
    public void yes()
    {
        thunderimg.SetActive(false);
        crane.gameObject.GetComponent<Animator>().enabled = true;
        Invoke("bijlitrue", 1.5f);
        Invoke("aagtrue", 4.5f);
        Invoke("yestrue", 6.5f);
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
    public void bijlitrue()
    {
        bijli1.SetActive(true);
        bijli2.SetActive(true);
    }
    public void aagtrue()
    {
        aag.SetActive(true);
       
    }
    public void yestrue()
    {
        yespanel.SetActive(true);
    }
}
