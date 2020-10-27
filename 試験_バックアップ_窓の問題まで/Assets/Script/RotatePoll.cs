using UnityEngine;
using System.Collections;

public class RotatePoll : MonoBehaviour
{

    void Update()
    {
        Quaternion rot = Quaternion.AngleAxis(3, Vector3.up);
        // 現在の自信の回転の情報を取得する。
        Quaternion q = this.transform.rotation;
        // 合成して、自身に設定
        this.transform.rotation = q * rot;
    }
}