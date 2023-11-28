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
        string MonthAndDay = DateTime.Now.ToString(("MM월 dd일"));
        DayTxt.text = "날짜 : " + MonthAndDay;

        string DayTime = DateTime.Now.ToString("t");
        TimeTxT.text = "시간 : " + DayTime;
    }

}