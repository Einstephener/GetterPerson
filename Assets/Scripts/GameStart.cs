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

    }
    public void ErrorMessage()
    {

    }
    public void ChangeName()
    {
        GameManager.I.textMeshName.text = GameManager.I.tmpName.text;
    }
}
