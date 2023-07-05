using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    static Manager s_instance;
    static Manager Instance { get { Init(); return s_instance; } }
    

    InputManager _input = new InputManager();
    ResourcManager _resource = new ResourcManager();
    public static InputManager Input { get { return Instance._input; } }
    public static ResourcManager Resourc { get { return Instance._resource; } }

    void Start()
    {
        Init();
    }

    void Update()
    {
        _input.OnUpdate();
    }

    static void Init()
    {
        if(s_instance == null)
        {
            GameObject go = GameObject.Find("@Managers");
            if(go == null)
            {
                go = new GameObject { name = "@Managers" };
                go.AddComponent<Manager>();
            }
            DontDestroyOnLoad(go);
            s_instance = go.GetComponent<Manager>();
        }
    }
}

