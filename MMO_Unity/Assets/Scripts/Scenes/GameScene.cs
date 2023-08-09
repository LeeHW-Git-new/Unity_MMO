using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        SceneTpye = Define.Scene.Game;

        Manager.UI.ShowSceneUI<UI_Inven>();
    }
    public override void Clear()
    {

    }
}
