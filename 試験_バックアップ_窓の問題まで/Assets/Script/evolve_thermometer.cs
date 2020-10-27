using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIを使うために必要
using UnityEngine.EventSystems; //イベントシステムを使うために必要

public class evolve_thermometer : MonoBehaviour, IPointerClickHandler
{ // クリックを取得するためのインターフェースを実装
  // [SerializeField] Text countText; // Textをアタッチ
    public int thm;

    // このスクリプトがアタッチされたオブジェクトがクリックされたときの処理
    public void OnPointerClick(PointerEventData eventData){
        Test_thermometer.thm = 1;
        Destroy(this.gameObject);
        thermometer.thm = 1;
    }
}
