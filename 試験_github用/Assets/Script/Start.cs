using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Start : MonoBehaviour
{
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("SampleScene");
        Test_alcohol.stoon = 0;
        Test_alcohol.fake = 0;
        alcohol.cont = 0;
        alcohol.stoon = 0;
        Test_Mask.msk = 0;
        Test_Mask.gft = 0;
        Mask.msk = 0;
        Mask.gft = 0;
        Test_thermometer.thm = 0;
        Test_thermometer.mom = 0;
        Test_thermometer.lie = 0;
        w_thermometer.thm = 0;
        thermometer.thm = 0;
        thermometer.mom = 0;
    }
}
