using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSetting : MonoBehaviour
{
   
    public void OpenNameSetting()
    {
        GameManager.I.settingPanel.SetActive(true);
        GameManager.I.inGameUI.SetActive(false);
        GameManager.I.closeBtn.SetActive(false);
    }

}
