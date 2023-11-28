using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterManager : MonoBehaviour
{
    
    public static CharacterManager instance;
    public void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != null) return;
    }

}
