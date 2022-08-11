using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class collidewithplayer : MonoBehaviour
{
    public static collidewithplayer instance;
    public GameObject player,player2,  cam2, cam1, black, smoke ,img ;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            black.SetActive(true);
            smoke.SetActive(true);
            Invoke("plaayer",1.0f);
            Invoke("plaayer1", 5.0f);
        }
    }


    void plaayer()
    {
        cam1.SetActive(false);
       // smoke.SetActive(true);
        cam2.SetActive(true);
        player.SetActive(false);
        player2.SetActive(true);
       // valve2.SetActive(true);
       // valve1.SetActive(false);

    }
    void plaayer1()
    {
        player2.SetActive(false);
        smoke.SetActive(false);
        img.SetActive(true);
        loadscene.instance.count++;
        print("loadscene.instance.count++");
        
    }


  public  void loadscene0()
    {
        SceneManager.LoadScene(0);
    }
}
