using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIを使うために必要
using UnityEngine.EventSystems; //イベントシステムを使うために必要

public class Wrong_thermometer : MonoBehaviour, IPointerClickHandler
{ // クリックを取得するためのインターフェースを実装
  // [SerializeField] Text countText; // Textをアタッチ
    public int fake;
    void Start()
    {
        // countText.text = ""; // テキスト初期化
    }

    // このスクリプトがアタッチされたオブジェクトがクリックされたときの処理
    public void OnPointerClick(PointerEventData eventData)
    {
        Test_thermometer.lie = 1;
        Destroy(this.gameObject);
        w_thermometer.thm = 1;
    }
}
