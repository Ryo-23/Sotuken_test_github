using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //UIを使うために必要
using UnityEngine.EventSystems; //イベントシステムを使うために必要

public class Test_Mask : MonoBehaviour, IPointerClickHandler
{ // クリックを取得するためのインターフェースを実装
    public static int msk;
    public static int gft;
    [SerializeField]
    GameObject Mask_2;


    // このスクリプトがアタッチされたオブジェクトがクリックされたときの処理
    public void OnPointerClick(PointerEventData eventData)
    {
        if (msk == 1)
        {
            Mask_2.SetActive(true);
            Mask.gft = 1;

        }


    }
}