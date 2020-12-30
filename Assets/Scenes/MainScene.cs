﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TapSDK;

public class MainScene : MonoBehaviour,LoginCallback
{
    // Start is called before the first frame update
    void Start()
    {
        TapSDK.TDSCore.Init("FwFdCIr6u71WQDQwQN");
        TapSDK.TDSLogin.RegisterLoginCallback(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LoginSuccess(TDSAccessToken accessToken)
    {
        Debug.Log("登陆成功:" + accessToken.ToJSON());
    }

    public void LoginCancel()
    {
        Debug.Log("登陆取消");
    }

    public void LoginError(TDSAccountError error)
    {
        Debug.Log("账户报错:" + error.ToJSON());
    }

    private void OnGUI()
    {
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button)
        {
            fontSize = 50
        };

        GUI.depth = 0;

        if (GUI.Button(new Rect(50, 200, 200, 60), "登陆", myButtonStyle))
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(2);
        }

        if (GUI.Button(new Rect(50, 300, 200, 60), "动态", myButtonStyle))
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(1);
        }

        if (GUI.Button(new Rect(50, 400, 200, 60), "TapDB", myButtonStyle))
        {
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(3);
        }

    }
}
