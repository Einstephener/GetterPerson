using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void StartBtn()
    {
        if (GameManager.I.tmpName.text.Length >= 2 && GameManager.I.tmpName.text.Length <= 10)
        {
            StartGame();
        }
        else
        {
            ErrorMessage();
        }
    }
    
    public void StartGame()
    {
        GameManager.I.settingPanel.SetActive(false);
        GameManager.I.inGameUI.SetActive(true);
        GameManager.I.closeBtn.SetActive(true);
        ChangeName();
        AddName();

    }
    public void AddName()
    {
        GameManager.I.inGamePlayers.text = GameManager.I.tmpName.text;
    }

    public void ErrorMessage()
    {
        GameManager.I.errorPanel.SetActive(true);
    }
    public void ChangeName()
    {
        GameManager.I.textMeshName.text = GameManager.I.tmpName.text;
        GameManager.I.textMeshName1.text = GameManager.I.tmpName.text;
        GameManager.I.textMeshName2.text = GameManager.I.tmpName.text;
    }
}
