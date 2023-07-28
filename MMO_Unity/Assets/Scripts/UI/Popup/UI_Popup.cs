using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Popup : UI_Base
{
    public virtual void Init()
    {
        Manager.UI.SetCanvas(gameObject, false);
    }

    public virtual void ClosePopupUI()
    {
        Manager.UI.ClosePopupUI(this);
    }
}
