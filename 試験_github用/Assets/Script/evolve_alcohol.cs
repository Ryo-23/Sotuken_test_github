using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIを使うために必要
using UnityEngine.EventSystems; //イベントシステムを使うために必要

public class evolve_alcohol : MonoBehaviour , IPointerClickHandler { // クリックを取得するためのインターフェースを実装
    // [SerializeField] Text countText; // Textをアタッチ
public int stoon;
  

    // このスクリプトがアタッチされたオブジェクトがクリックされたときの処理
    public void OnPointerClick(PointerEventData eventData) {
        Test_alcohol.stoon = 1;
        Destroy(this.gameObject);
        alcohol.stoon = 1;
    }
}