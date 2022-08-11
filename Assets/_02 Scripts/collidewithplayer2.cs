using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidewithplayer2 : MonoBehaviour
{
    


    public GameObject black, paneltogonext, paneltogonext1, paneltogonext2, player,playercam, drillman1, drillman2,valv1,valve2, chain,chain1, cameralerp;
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
            paneltogonext.SetActive(true);
          //  black.SetActive(true);
          //  
          //  
          //   Invoke("plaayer3", 10.0f);
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }


    void plaayer()
    {
        player.SetActive(false);
        playercam.SetActive(false);
        valv1.gameObject.GetComponent<Rotationobj>().enabled = true;
        drillman1.SetActive(true);
        black.SetActive(false);

    }
    void plaayer1()
    {
        drillman1.SetActive(false);
        valv1.gameObject.GetComponent<Rotationobj>().enabled = false;
        drillman2.SetActive(true);
        valve2.gameObject.GetComponent<Rotationobj>().enabled = true;
        //black.SetActive(false);
    }
    void plaayer2()
    {
        black.SetActive(true);
       
    }


    public void next()
    {
       this .gameObject.GetComponent<MeshRenderer>().enabled = false;
        black.SetActive(true);
        Invoke("plaayer", 1.0f);
        Invoke("plaayer2", 4.0f);
          Invoke("plaayer1", 5.0f);
        Invoke("plaayer3", 10.0f);
    }


    public void next1()
    {
       // this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        black.SetActive(true);
        valve2.gameObject.GetComponent<Rotationobj>().enabled = false;


        Invoke("plaayerlock", 1.0f);
        Invoke("plaayer2", 3.0f);
        Invoke("plaayer1lock", 4.0f);
        Invoke("plaayer2lock", 6.0f);

        //Invoke("plaayer3", 10.0f);
    }
    void plaayerlock()
    {
        drillman2.SetActive(false);
        drillman1.SetActive(true);
        chain.SetActive(true);
        black.SetActive(false);

    }
    void plaayer1lock()
    {
        drillman1.SetActive(false);
       // valv1.gameObject.GetComponent<Rotationobj>().enabled = false;
        drillman2.SetActive(true);
        chain1.SetActive(true);
        //valve2.gameObject.GetComponent<Rotationobj>().enabled = true;
        //black.SetActive(false);
    }

    void plaayer2lock()
    {
        paneltogonext2.SetActive(true);
        drillman2.SetActive(false);
        cameralerp.SetActive(true);
    }


    void plaayer3()
    {
        black.SetActive(false);
        paneltogonext1.SetActive(true);


    }



}
