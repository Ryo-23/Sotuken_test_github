using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //UIを使うために必要
using UnityEngine.EventSystems; //イベントシステムを使うために必要

public class Test_thermometer : MonoBehaviour, IPointerClickHandler
{ // クリックを取得するためのインターフェースを実装
    public static int thm;
    public static int lie;
    public static int mom;
    [SerializeField]
    Text countText; // Textをアタッチ
    [SerializeField]
    GameObject itemBtn_thermometer;
    int count;

    void Start()
    {
        // countText.text = ""; // テキスト初期化
    }

    // このスクリプトがアタッチされたオブジェクトがクリックされたときの処理
    public void OnPointerClick(PointerEventData eventData)
    {
        if (thm == 1)
        {
            countText.text = "解決！！";
            thermometer.mom = 1;

        }
        else if (lie == 1)
        {
            countText.text = "残念!!";
        }


    }
}
