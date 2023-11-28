using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public GameObject settingPanel;
    public GameObject inGameUI;
    public GameObject doYouTalkUI;
    public GameObject talkUI;
    public GameObject errorPanel;
    public GameObject openBtn;
    public GameObject closeBtn;
    public GameObject errorBtn;
    public TextMesh textMeshName;
    public TextMesh textMeshName1;
    public TextMesh textMeshName2;
    public TextMesh tmpNPCName;
    public TMP_Text tmpName;
    public Text inGamePlayers;
    public Text WhoTalk;
    public Text inGameNPCs;
    public Text talk;
    public SpriteRenderer Character;
    public GameObject Black;
    public GameObject Brown;
    public GameObject Red;
    public Image highlight;
    public Transform target;              
    public Transform target0;
    public Transform target1;
    public Transform target2;

    public int playerId = 0;

    private void Awake()
    {
        I = this;
    }

    private void Start()
    {
        SettingNPCName();
    }

    private void SettingNPCName()
    {
        inGameNPCs.text = tmpNPCName.text;
    }

}
