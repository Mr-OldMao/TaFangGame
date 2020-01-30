using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 外观模式（Facade Pattern）
/// 隐藏系统的复杂性，并向客户端提供了一个客户端可以访问系统的接口。
/// 这种类型的设计模式属于结构型模式，它向现有的系统添加一个接口，来隐藏系统的复杂性。
/// </summary>
public class GameFacade
{
    private bool m_IsGameOver = false;
    public bool isGameOver { get { return m_IsGameOver; } }

    //使用单例模式
    private static GameFacade m_Instance;
    public static GameFacade GetInstance()
    {
        if (m_Instance == null)
            m_Instance = new GameFacade();
        return m_Instance;
    }

    private GameFacade() { }


    public void Init()
    {

    }

    public void Update()
    {

    }
    public void Release()
    {

    }
}
