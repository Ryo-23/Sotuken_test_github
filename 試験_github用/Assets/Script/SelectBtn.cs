using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UIを使うために必要
using UnityEngine.EventSystems; //イベントシステムを使うために必要


public class SelectBtn : MonoBehaviour
{
    [SerializeField]
    GameObject NearWindow;
    [SerializeField]
    GameObject NearCopy;
    [SerializeField]
    GameObject NearBoard;

    // Update is called once per frame
    public void OnPointerClick(PointerEventData eventData)
    {
        NearWindow.SetActive(true);
        NearCopy.SetActive(true);
        NearBoard.SetActive(true);
    }

}
