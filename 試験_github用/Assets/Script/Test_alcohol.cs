using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //UIを使うために必要
using UnityEngine.EventSystems; //イベントシステムを使うために必要

public class Test_alcohol : MonoBehaviour, IPointerClickHandler
{ // クリックを取得するためのインターフェースを実装
    public static int stoon;
    public static int fake;
    public static int cont;
    [SerializeField]
    Text countText; // Textをアタッチ
    [SerializeField]
    GameObject itemBtn_alcohol;

    void Start()
    {
        // countText.text = ""; // テキスト初期化
    }

    // このスクリプトがアタッチされたオブジェクトがクリックされたときの処理
    public void OnPointerClick(PointerEventData eventData)
    {
        if (stoon == 1)
        {
            countText.text = "解決！！";
            alcohol.cont = 1;
            SceneManager.LoadScene("Clear");

        }
        else if (fake == 1)
        {
            countText.text = "残念!!";
        }

        
    }
}