using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mask : MonoBehaviour
{
    public static int msk;
    public static int gft;
    [SerializeField]
    GameObject itemBtn_mask;



    void Update()
    {
        if (msk == 1 )
        {
            //ゲームオブジェクト非表示→表示
            itemBtn_mask.SetActive(true);
        }
         if (gft == 1){
            msk = 0;
            Destroy(itemBtn_mask.gameObject);
        }
    }
}