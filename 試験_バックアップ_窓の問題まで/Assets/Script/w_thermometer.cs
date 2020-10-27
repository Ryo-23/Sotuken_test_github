using UnityEngine;

public class w_thermometer : MonoBehaviour
{
    public static int thm;
    public static int mom;
    [SerializeField]
    GameObject itemBtn_ondo;



    void Update()
    {
        //[D]キーを押す
        if (thm == 1)
        {
            //ゲームオブジェクト非表示→表示
            itemBtn_ondo.SetActive(true);
        }
        if (mom == 1)
        {
            thm = 0;
            Destroy(itemBtn_ondo.gameObject);
        }
    }
}