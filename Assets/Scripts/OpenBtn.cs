using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBtn : MonoBehaviour
{
    public void ClickOpenBtn()
    {
        GameManager.I.inGameUI.SetActive(true);
        GameManager.I.openBtn.SetActive(false);
        GameManager.I.closeBtn.SetActive(true);
    }
}
