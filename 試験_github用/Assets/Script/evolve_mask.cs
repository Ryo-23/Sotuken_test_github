using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIを使うために必要
using UnityEngine.EventSystems; //イベントシステムを使うために必要

public class evolve_mask : MonoBehaviour, IPointerClickHandler
{ 
    public int msk;

    // このスクリプトがアタッチされたオブジェクトがクリックされたときの処理
    public void OnPointerClick(PointerEventData eventData) {
        Destroy(this.gameObject);
        Mask.msk = 1;
        Test_Mask.msk = 1;
    }
}