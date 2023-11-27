using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OKBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void ClickOk()
    {
        GameManager.I.errorPanel.SetActive(false);
    }
}
