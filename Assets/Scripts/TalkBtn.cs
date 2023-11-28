using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkBtn : MonoBehaviour
{
    public void Action()
    {
        GameManager.I.doYouTalkUI.SetActive(false);
        GameManager.I.talkUI.SetActive(true);
    }
}
