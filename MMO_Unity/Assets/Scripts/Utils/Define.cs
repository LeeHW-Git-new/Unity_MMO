﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum Scene
    {
        Unkown,
        Login,
        Lobby,
        Game,
    }
    public enum Sound
    {
        BGM,
        Effect,
        MaxCount,
    }
    public enum UIEvent
    {
        Click,
        Drag,
    }
    public enum MouseEvent
    {
        Press,
        Click,
    }
    public enum CameraMode
    {
        QuarterView,
    }
}
