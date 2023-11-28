using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsHeNearby : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D NPC)
    {
        if (NPC.gameObject.name == "NPC")
        {
            GameManager.I.WhoTalk.text = NPC.gameObject.name;
            GameManager.I.doYouTalkUI.SetActive(true);
        }
        
    }
    void OnTriggerExit2D(Collider2D NPC)
    {
        if (NPC.gameObject.name == "NPC")
        {
            GameManager.I.doYouTalkUI.SetActive(false);
            GameManager.I.talkUI.SetActive(false);
        }
    }
}
