using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterChoose : MonoBehaviour
{

    SpriteRenderer sr;

    public void Choose(int id)
    {
        GameManager.I.playerId = id;
        if (GameManager.I.playerId == 0)
        {
            GameManager.I.Black.SetActive(true);
            GameManager.I.Brown.SetActive(false);
            GameManager.I.Red.SetActive(false);
        }
        else if (GameManager.I.playerId == 1)
        {
            GameManager.I.Black.SetActive(false);
            GameManager.I.Brown.SetActive(true);
            GameManager.I.Red.SetActive(false);
        }
        else if (GameManager.I.playerId == 2)
        {
            GameManager.I.Black.SetActive(false);
            GameManager.I.Brown.SetActive(false);
            GameManager.I.Red.SetActive(true);
        }
    }
    private void OnDeSelect()
    {
        sr.color = new Color(0.5f, 0.5f, 0.5f);
    }

    void OnSelect()
    {
        sr.color = new Color(1f, 1f, 1f);
    }
}
