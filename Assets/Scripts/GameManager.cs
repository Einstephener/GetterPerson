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
    public GameObject errorPanel;
    public GameObject openBtn;
    public GameObject closeBtn;
    public GameObject errorBtn;
    public TextMesh textMeshName;
    public TMP_Text tmpName;
    public Text inGamePlayers;
    public SpriteRenderer Character;
    public GameObject Black;
    public GameObject Brown;
    public GameObject Red;



    public int playerId;
    private void Awake()
    {
        I = this;
    }

    
}
