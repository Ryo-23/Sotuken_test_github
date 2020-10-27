using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinpong : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpSpeed;
    private float Rx;
    private float Ry;
    private float y = 3;
    private float x = 3;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("hoge", x, y);
    }

    void Update(){
        Rx = Random.Range(1f, 3f);
        Ry = Random.Range(1f, 3f);
        // Debug.Log(Rx);
    }

    void hoge()
    {
        rb.velocity = Vector3.up * jumpSpeed;
        x = Rx;
        y = Ry;
    }
}