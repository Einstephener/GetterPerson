using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterChoose : MonoBehaviour
{
    public Character character;
    SpriteRenderer sr;
    public CharacterChoose[] chars;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        if (CharacterManager.instance.currentCharacter == character) OnSelect();
        else OnDeSelect();
    }
    private void OnMouseUpAsButton()
    {
        CharacterManager.instance.currentCharacter = character;
        OnSelect();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i]!= this) chars[i].OnDeSelect();
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
