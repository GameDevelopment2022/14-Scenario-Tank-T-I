using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager1 : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject[] cams;
    // Start is called before the first frame update
    

    void Start()
    {
        
        StartCoroutine(camwork());
    }

    // Update is called once per frame

    IEnumerator camwork()
    {

        yield return new WaitForSeconds(2f);
        objects[2].SetActive(true);
        yield return new WaitForSeconds(7f);
        objects[1].SetActive(true);
        yield return new WaitForSeconds(1f);
        objects[0].SetActive(true);
        cams[0].SetActive(true);
        cams[1].SetActive(false);
        yield return new WaitForSeconds(1f);
        objects[1].SetActive(false);
        objects[2].SetActive(false);
        yield return new WaitForSeconds(3f);
        objects[3].SetActive(true);
    }
}
