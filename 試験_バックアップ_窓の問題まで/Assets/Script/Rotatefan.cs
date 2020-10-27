using UnityEngine;
using System.Collections;

public class Rotatefan : MonoBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 100));
    }
}