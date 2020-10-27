using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alcohol : MonoBehaviour
{
    public static int stoon;
    public static int cont;
    [SerializeField]
    GameObject itemBtn_alcohol;



    void Update()
    {
        //[D]キーを押す
        if (stoon == 1)
        {
            //ゲームオブジェクト非表示→表示
            itemBtn_alcohol.SetActive(true);
        }
        if(cont == 1)
        {
            stoon = 0;
            Destroy(itemBtn_alcohol.gameObject);
        }
    }
}