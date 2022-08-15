using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public static loadscene instance;
    public GameObject loading,main, liftingoperation;
    public int count;

    void Start()
    {
        instance = this;
        count = 0;
    }
    public void onclickpipeisolation()
    {
        loading.SetActive(true);
        main.SetActive(false);
        Invoke("load", 2.0f);
        count++;
    }



    public void blockvalve()
    {
        liftingoperation.SetActive(true);
        main.SetActive(false);
       
    }


    public void liftoperationbutton()
    {
        loading.SetActive(true);
        liftingoperation.SetActive(false);
        Invoke("loadscene3", 2.0f);
       // count++;
    }

    public void heavyequipment()
    {
        loading.SetActive(true);
       // liftingoperation.SetActive(false);
        Invoke("loadscene4", 2.0f);
       //count++;
    }

    public void heavyequipment2()
    {
        loading.SetActive(true);
      //  liftingoperation.SetActive(false);
        Invoke("loadscene5", 2.0f);
        //count++;
    }

    public void heavyequipment3()
    {
        loading.SetActive(true);
        //  liftingoperation.SetActive(false);
        Invoke("loadscene6", 2.0f);
        //count++;
    }
    // Update is called once per frame


    public void exit()
    {
        Application.Quit();
    }

    public void load()
    {
        SceneManager.LoadScene(1);
    }

    public void loadscene3()
    {
        SceneManager.LoadScene(3);
    }
    public void loadscene4()
    {
        SceneManager.LoadScene(8);
    }

    public void loadscene5()
    {
        SceneManager.LoadScene(9);
    }
    public void loadscene6()
    {
        SceneManager.LoadScene(10);
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (count==0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                onclickpipeisolation();
               // count++;
                print(count);
            }
        }
        
    }
}
