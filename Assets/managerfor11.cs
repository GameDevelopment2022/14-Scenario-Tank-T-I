using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class managerfor11 : MonoBehaviour
{
    public GameObject cam1, butto, cam2, pipelineimg, crane,pipe ,yespanel, nopanel, pipe2
        ;

    public void Start()
    {
        Invoke("blackactive", 6.0f);
      //  Invoke("playeractive", 7.0f);
    }

    public void near()
    {
        crane.gameObject.GetComponent<Animator>().enabled = true;
        pipe.SetActive(true);
        Invoke("crash", 4.0f);
        Invoke("yestrue", 5.5f);
    }
    public void away()
    {
        crane.gameObject.GetComponent<Animator>().enabled = true;
        pipe2.SetActive(true);
       
        Invoke("notrue", 4.5f);
    }
    public void crash()
    {
        pipe.gameObject.transform.GetChild(0).GetComponent<Rigidbody>().isKinematic = false;


    }
    public void blackactive()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        butto.SetActive(true);

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
