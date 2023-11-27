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
    public Image CharacterImage1;
    public Image CharacterImage2;
    public Image CharacterImage3;
    public TextMesh textMeshName;
    public TMP_Text tmpName;
    public Text players;
    public SpriteRenderer Character;

    private void Awake()
    {
        I = this;
    }

    
}
