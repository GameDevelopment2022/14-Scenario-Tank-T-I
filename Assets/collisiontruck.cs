using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class collisiontruck : MonoBehaviour
{
    public GameObject thunderimg, truck, truck1,truck1cam, nopanel,yespanel,crane,crane1;
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
       // crane.gameObject.GetComponent<Animator>().enabled = true;
        truck1.SetActive(true);
        truck1cam.SetActive(true);
        truck.SetActive(false);

        Invoke("notrue", 4.5f);
        // nopanel.SetActive(true);
    }
    public void yes()
    {
        thunderimg.SetActive(false);
        crane.gameObject.GetComponent<Animator>().enabled = true;
        truck1.SetActive(true);
        truck1cam.SetActive(true);
        truck.SetActive(false);
        Invoke("cran", 2.25f);
        Invoke("yestrue", 4.5f);

    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }

    public void cran()
    {
        crane1.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        crane.gameObject.GetComponent<Animator>().enabled = false;
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
