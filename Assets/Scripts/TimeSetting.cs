using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TimeSetting : MonoBehaviour
{
    public Text DayTxt;
    public Text TimeTxT;


    void Update()
    {
        GetCurrentDate();
    }
    public void GetCurrentDate()
    {
        string MonthAndDay = DateTime.Now.ToString(("MM�� dd��"));
        DayTxt.text = "��¥ : " + MonthAndDay;

        string DayTime = DateTime.Now.ToString("t");
        TimeTxT.text = "�ð� : " + DayTime;
    }

}