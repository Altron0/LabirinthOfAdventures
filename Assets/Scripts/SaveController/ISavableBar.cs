using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISavableBar : MonoBehaviour
{
    public int getBarCount()
    {
        Bar bar = GetComponent<Bar>();
        return bar.count;
    }

    public void setBarCount(int countBar)
    {
        Bar s = transform.GetComponent<Bar>();
        s.count = countBar;
    }
}
