using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class collidewithplayer3 : MonoBehaviour
{
    


    public GameObject black,playeri, playercam , sign1, camerasign, sign2, cranecam, cranedriv,hazardpanel, windpanel, windcam, nopanel,lift,balanceimg;
    // Start is called before the first frame update
    void Start()
    {
        black.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            black.SetActive(true);
           // playeri.SetActive(false);
            Invoke("signature1", 1f);
            Invoke("blackfalse", 1.5f);
            Invoke("blacktrue", 3.0f);
            Invoke("signature2", 3.8f);
            Invoke("blackfalse", 4.5f);
            Invoke("blacktrue", 5.5f);
            Invoke("signature3", 6.4f);
            Invoke("blackfalse", 6.6f);
            Invoke("signature4", 13.4f);
        }

    }


    public void blackfalse()
    {
        black.SetActive(false);
    }

    public void blacktrue()
    {
        black.SetActive(true);
    }
    public void signature1()
    {
        playeri.SetActive(false);
        playercam.SetActive(false);
        sign1.SetActive(true);
        camerasign.SetActive(true);
    }
    public void signature2()
    {
        sign1.SetActive(false);
        sign2.SetActive(true);
    }
    public void signature3()
    {
        sign1.SetActive(false);
        sign2.SetActive(false);
        camerasign.SetActive(false);
        cranecam.SetActive(true);
        cranedriv.SetActive(true);
    }
    public void signature4()
    {
        hazardpanel.SetActive(true);
       // cranecam.SetActive(false);
       // windcam.SetActive(true);
    }
    public void falling()
    {
        cranecam.SetActive(false);
         windcam.SetActive(true);
        hazardpanel.SetActive(false);
        Invoke("windpactive", 3.0f);
    }

    public void windpactive()
    {
        windpanel.SetActive(true);
    }

    public void no()
    {
        windpanel.SetActive(false);
        nopanel.SetActive(true);
    }
    public void yes()
    {
        lift.gameObject.GetComponent<Animator>().enabled = true;
        windpanel.SetActive(false);
        Invoke("cranebalance", 7.0f);
    }


    public void cranebalance()
    {
        balanceimg.SetActive(true);
    }
    public void restart()
    {
        SceneManager.LoadScene(0);
    }
    public void struckthunder()
    {
        SceneManager.LoadScene(5);
    }
    public void objectdamage()
    {
        SceneManager.LoadScene(6);
    }
    public void collision()
    {
        SceneManager.LoadScene(7);
    }
}
