using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBtn : MonoBehaviour
{ 
    public void ClickCloseBtn()
    {
        GameManager.I.inGameUI.SetActive(false);
        GameManager.I.openBtn.SetActive(true);
        GameManager.I.closeBtn.SetActive(false);
    }
}
