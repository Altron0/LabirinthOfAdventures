using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scills : MonoBehaviour
{
    [SerializeField] Text count;
    [SerializeField] public Text AllCount;

    [SerializeField] Text smekl;
    [SerializeField] Text lowk;
    [SerializeField] Text power;

    void PlusOchko()
    {
        int allCount = Convert.ToInt32(AllCount.text);
        Debug.Log(allCount);

        if (allCount > 0)
        {
            int a = Convert.ToInt32(count.text);
            count.text = (a + 1).ToString();
            AllCount.text = (allCount - 1).ToString();
        }
    }

    void MinusOchko()
    {
        int allCount = Convert.ToInt32(AllCount.text);
        int a = Convert.ToInt32(count.text);
        if (a > 1)
        {

            count.text = (a - 1).ToString();
            AllCount.text = (allCount + 1).ToString();
        }
    }

    void RestartCount()
    {
        int smekll = Convert.ToInt32(smekl.text);
        int low = Convert.ToInt32(lowk.text);
        int powers = Convert.ToInt32(power.text);

        AllCount.text = ((smekll + low + powers) - 2).ToString();

        smekl.text = (1).ToString();
        power.text = (1).ToString();
        lowk.text = (1).ToString();

    }
}
