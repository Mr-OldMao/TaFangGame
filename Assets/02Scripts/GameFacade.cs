using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 外观模式（Facade Pattern）
/// 中介者模式
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

    //系统实例
    private ArchievementSystem m_ArchievementSystem;    //成就系统
    private CampSystem m_CampSystem;            //兵营系统
    private CharacterSystem m_CharacterSystem;  //角色系统
    private EnergySystem m_EnergySystem;        //能量系统
    private GameEventSystem m_GameEventSystem;  //游戏时间系统
    private StageSystem m_StageSystem;          //关卡系统

    private CampInfoUI m_CampInfoUI;            //兵营信息显示
    private GamePauseUI m_GamePauseUI;          //游戏暂停
    private GameStateInfoUI m_GameStateInfoUI;  //游戏状态
    private SoldierInfoUI m_SoldierInfoUI;      //战士信息

    public void Init()
    {
        m_ArchievementSystem = new ArchievementSystem();
        m_CampSystem = new CampSystem();
        m_CharacterSystem = new CharacterSystem();
        m_EnergySystem = new EnergySystem();
        m_GameEventSystem = new GameEventSystem();
        m_StageSystem = new StageSystem();

        m_CampInfoUI = new CampInfoUI();
        m_GamePauseUI = new GamePauseUI();
        m_GameStateInfoUI = new GameStateInfoUI();
        m_SoldierInfoUI = new SoldierInfoUI();

        m_ArchievementSystem.Init();
        m_CampSystem.Init();
        m_CharacterSystem.Init();
        m_EnergySystem.Init();
        m_GameEventSystem.Init();
        m_StageSystem.Init();
        m_CampInfoUI.Init();
        m_GamePauseUI.Init();
        m_GameStateInfoUI.Init();
        m_SoldierInfoUI.Init();
    }

    public void Update()
    { 
        m_ArchievementSystem.Update();
        m_CampSystem.Update();
        m_CharacterSystem.Update();
        m_EnergySystem.Update();
        m_GameEventSystem.Update();
        m_StageSystem.Update();
        m_CampInfoUI.Update();
        m_GamePauseUI.Update();
        m_GameStateInfoUI.Update();
        m_SoldierInfoUI.Update();
    }
    public void Release()
    {
        m_ArchievementSystem.Release();
        m_CampSystem.Release();
        m_CharacterSystem.Release();
        m_EnergySystem.Release();
        m_GameEventSystem.Release();
        m_StageSystem.Release();
        m_CampInfoUI.Release();
        m_GamePauseUI.Release();
        m_GameStateInfoUI.Release();
        m_SoldierInfoUI.Release();
    }
}
