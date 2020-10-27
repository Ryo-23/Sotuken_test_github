using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; //UIを使うために必要
using UnityEngine.EventSystems; //イベントシステムを使うために必要

public class mitudesu : MonoBehaviour, IPointerClickHandler
{
    public static int sound=0;


    public void OnPointerClick(PointerEventData eventData)
    {
        sound = sound + 1;
        if (sound == 1)
        {
            GetComponent<AudioSource>().Play();
        }



    }

} 
