using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterChoose : MonoBehaviour
{
    public void Choose(int id)
    {
        GameManager.I.playerId = id;
        Debug.Log("playerId 를 id로 변경");

        if (GameManager.I.playerId == 0)
        {
            Debug.Log("검정이 선택됨");
            Vector2 position = GameManager.I.highlight.transform.localPosition;
            position.x = -170;
            position.y = -10;
            GameManager.I.highlight.transform.localPosition = position;
            GameManager.I.Black.SetActive(true);
            GameManager.I.Brown.SetActive(false);
            GameManager.I.Red.SetActive(false);
            GameManager.I.target = GameManager.I.target0;
        }
        else if (GameManager.I.playerId == 1)
        {
            Debug.Log("갈색이 선택됨");
            Vector2 position = GameManager.I.highlight.transform.localPosition;
            position.x = 0;
            position.y = -10;
            GameManager.I.highlight.transform.localPosition = position;
            GameManager.I.Black.SetActive(false);
            GameManager.I.Brown.SetActive(true);
            GameManager.I.Red.SetActive(false);
            GameManager.I.target = GameManager.I.target1;
        }
        else if (GameManager.I.playerId == 2)
        {
            Debug.Log("빨강이 선택됨");
            Vector2 position = GameManager.I.highlight.transform.localPosition;
            position.x = 170;
            position.y = -10;
            GameManager.I.highlight.transform.localPosition = position;
            GameManager.I.Black.SetActive(false); 
            GameManager.I.Brown.SetActive(false);
            GameManager.I.Red.SetActive(true);
            GameManager.I.target = GameManager.I.target2;
        }
    }

}
