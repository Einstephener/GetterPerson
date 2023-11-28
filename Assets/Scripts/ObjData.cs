using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjData : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D NPC)
    {
        if (NPC.gameObject.name == "NPC")
        {
            GameManager.I.TalkUI.SetActive(true);
        }
        
    }
    void OnTriggerExit2D(Collider2D NPC)
    {
        if (NPC.gameObject.name == "NPC")
        {
            GameManager.I.TalkUI.SetActive(false);
        }
    }
}
