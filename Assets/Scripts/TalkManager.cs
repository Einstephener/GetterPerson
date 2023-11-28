using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkManager : MonoBehaviour
{
    Dictionary<int, string[]> talkData;
    private void Awake()
    {
        talkData = new Dictionary<int, string[]>();//초기화
        GenerateData();
    }

    private void GenerateData()
    {
        talkData.Add(1000, new string[] { "네, 안녕하세요", "무슨일인가요?" });
    }

    public string GetTalk(int id, int talkIndex)
    {

        return talkData[id][talkIndex];
    }
}
