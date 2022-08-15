using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class grounded : MonoBehaviour
{
    public GameObject pole1, pole2, crane, pipe, nopanel, yespanel, blast ;
    void Start()
    {
        
    }

    public void near()
    {
        crane.gameObject.GetComponent<Animator>().enabled = true;
        pole1.SetActive(true);
        Invoke("crash", 4.0f);
        Invoke("yestrue", 5.5f);
    }
    public void away()
    {
        crane.gameObject.GetComponent<Animator>().enabled = true;
        pole2.SetActive(true);

        Invoke("notrue", 4.5f);
    }
    public void crash()
    {
        pipe.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        blast.SetActive(true);

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
