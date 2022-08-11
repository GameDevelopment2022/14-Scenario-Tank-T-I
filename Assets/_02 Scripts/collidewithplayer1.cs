using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class collidewithplayer1 : MonoBehaviour
{
    public GameObject player,player2, desk, cam2, cam1,cam3, black,followarrows,
       arrow , arrow1, cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
           
            black.SetActive(true);
            Invoke("plaayer",1.0f);
            Invoke("plaayer2", 4.0f);
            Invoke("plaayer1", 5.0f);
         //   Invoke("plaayer3", 10.0f);
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }


    void plaayer()
    {
        cam1.SetActive(false);
        cam2.SetActive(true);
        player.SetActive(false);
      //  img2.SetActive(false);
        // player2.SetActive(true);
        // valve2.SetActive(true);
        //  valve1.SetActive(false);
        black.SetActive(false);

    }
    void plaayer1()
    {
        //followarrows.SetActive(true);
        SceneManager.LoadScene(2);
      //  valve2.SetActive(false);
    }
    void plaayer2()
    {
        black.SetActive(true);
       
    }



    public void player33()
    {
        player2.SetActive(true);
        desk.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
        arrow.SetActive(true);
        arrow1.SetActive(false);
        cube.SetActive(true);
    }
    //void plaayer3()
    //{
    //    black.SetActive(false);
    //    img.SetActive(false);
        

    //}
}
