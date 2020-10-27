using UnityEngine;

public class thermometer : MonoBehaviour
{
    public static int thm;
    public static int mom;
    [SerializeField]
    GameObject itemBtn_thermometer;



    void Update()
    {
        //[D]キーを押す
        if (thm == 1)
        {
            //ゲームオブジェクト非表示→表示
            itemBtn_thermometer.SetActive(true);
        }
        if (mom == 1)
        {
            thm = 0;
            Destroy(itemBtn_thermometer.gameObject);
        }
    }
}