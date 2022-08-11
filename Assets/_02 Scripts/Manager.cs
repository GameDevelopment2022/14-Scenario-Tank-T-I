using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject[] cams;
    // Start is called before the first frame update
    

    void Start()
    {
        
    //    StartCoroutine(camwork());
    }

    // Update is called once per frame

    //IEnumerator camwork()
    //{

    //    yield return new WaitForSeconds(12f);
    //    objects[0].SetActive(true);

    //}



    public void skip()
    {
        objects[0].SetActive(true);
            objects[5].SetActive(false);
        loadscene.instance.count++;

    }
    public void Update()
    {
        if (loadscene.instance.count == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                skip();
            }
        }

        if (loadscene.instance.count == 3)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                collidewithplayer.instance.loadscene0();
            }
        }


        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    wearsfety();
        //}
    }


    public void wearsfety()
    {
       
        cams[0].SetActive(false);
        cams[1].SetActive(true);
        objects[1].SetActive(true);
        objects[2].SetActive(true);
        objects[4].SetActive(true);
    
}
    public void skipsafety()
    {
        objects[1].SetActive(false);
        cams[0].SetActive(false);
        cams[1].SetActive(true);
        objects[2].SetActive(true);
        objects[3].SetActive(true);
       // objects[5].SetActive(true);
    }

}
