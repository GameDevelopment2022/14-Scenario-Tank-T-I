using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidewithplayer3 : MonoBehaviour
{
    


    public GameObject black,playeri , sign1, camerasign, sign2, cranecam, cranedriv;
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
            black.SetActive(true);
            playeri.SetActive(false);
            Invoke("signature1", 0.5f);
            Invoke("blackfalse", 1.0f);
            Invoke("blacktrue", 3.0f);
            Invoke("signature2", 3.5f);
            Invoke("blackfalse", 4.0f);
            Invoke("blacktrue", 5.5f);
            Invoke("signature3", 6f);
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
}
