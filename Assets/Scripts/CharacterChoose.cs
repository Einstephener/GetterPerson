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
        Debug.Log("playerId �� id�� ����");
        MainCamera_Action mainCameraAction = GameManager.I.GetComponent<MainCamera_Action>();
        if (mainCameraAction != null)
        {
            mainCameraAction.SetTargetByPlayerId(GameManager.I.playerId);
            Debug.Log("Choose���� Camera��");
        }
        if (GameManager.I.playerId == 0)
        {
            Debug.Log("������ ���õ�");
            Vector2 position = GameManager.I.highlight.transform.localPosition;
            position.x = -170;
            position.y = -10;
            GameManager.I.highlight.transform.localPosition = position;
            GameManager.I.Black.SetActive(true);
            GameManager.I.Brown.SetActive(false);
            GameManager.I.Red.SetActive(false);
        }
        else if (GameManager.I.playerId == 1)
        {
            Debug.Log("������ ���õ�");
            Vector2 position = GameManager.I.highlight.transform.localPosition;
            position.x = 0;
            position.y = -10;
            GameManager.I.highlight.transform.localPosition = position;
            GameManager.I.Black.SetActive(false);
            GameManager.I.Brown.SetActive(true);
            GameManager.I.Red.SetActive(false);
        }
        else if (GameManager.I.playerId == 2)
        {
            Debug.Log("������ ���õ�");
            Vector2 position = GameManager.I.highlight.transform.localPosition;
            position.x = 170;
            position.y = -10;
            GameManager.I.highlight.transform.localPosition = position;
            GameManager.I.Black.SetActive(false); 
            GameManager.I.Brown.SetActive(false);
            GameManager.I.Red.SetActive(true);
        }
    }

}
