using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeLerpController : MonoBehaviour
{

    [SerializeField] List<Transform> posTransforms;


    private bool isLerping = false;
    private static float t = 0.0f;


    [SerializeField] public GameObject cam;

    [SerializeField] float firstlerpSpeed;
    [SerializeField] float lerpSpeed;
    public AudioClip cameraanim;

   // private int lerpTimed = 0;
 //   private int currentBase = 0;

    private Transform currentTrans;
    private Transform targetTrans;

    // Start is called before the first frame update
    void Start()
    {
      //  Invoke("Lerp", 2f);
     //   Invoke("Lerp1", 5f);
        


    }


    //private void Lerp()
    //{
    //    LerpTo(0);
    //}

    //private void Lerp1()
    //{
    //    LerpTo(1);
    //}


    public void LerpTo(int whichPos)
    {
        targetTrans = posTransforms[whichPos];
        targetTrans = posTransforms[whichPos];

        isLerping = true;
        //if (whichPos == 2)
        //{
        //    if (FindObjectOfType<StoreManager>() != null)
        //    {
        //        if (FindObjectOfType<StoreManager>().isBuy)
        //            return;
        //    }


        //}



        // MenuManager.instance.sfx[2].PlayOneShot(cameraanim);

    }




    private void FixedUpdate()
    {
        if (isLerping)
        {
            cam.transform.position = Vector3.Lerp(cam.transform.position, targetTrans.position, t);
            cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, targetTrans.rotation, t);


            //if (lerpTimed == 0)
            //{
            //    t += firstlerpSpeed * Time.deltaTime;
            //}
            //else
            //{
                t += lerpSpeed * Time.deltaTime;
          //  }


            if (t >= 1.0f)
            {
                isLerping = false;
                t = 0f;
            }
        }

    }

}
