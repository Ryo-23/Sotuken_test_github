using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReStart : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Start");
    }
}
