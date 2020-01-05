using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 场景状态控制器
/// 使用 状态设计模式
/// </summary>
public class SceneStateControl {

    private ISceneState m_State;

    private AsyncOperation m_Ao;    //异步加载

    private bool m_IsRunStart = false; //判断是否执行过一次StateStart方法


    /// <summary>
    /// 设置状态
    /// </summary>
    /// <param name="state"></param>
    /// <param name="isLoadScene">是否需要加载场景</param>
    public void SetState(ISceneState state,bool isLoadScene = true)
    {
        if (m_State != null)
        {
            m_State.StateEnd();  //让上一个场景进行清理工作
        }
        m_State = state;

        if (isLoadScene)
        {
            //异步加载场景
            m_Ao = SceneManager.LoadSceneAsync(m_State.SceneName);
            m_IsRunStart = false;
        }
        else
        {
            m_State.StateStart();
            m_IsRunStart = true;
        }
    }

     
    public void StateUpdate()
    {
        if (m_Ao != null && m_Ao.isDone == false)
        {
            Debug.Log("正在加载场景");
            return;
        }

        if (m_Ao != null && m_Ao.isDone ==true && m_IsRunStart==false)
        {
            m_State.StateStart();
            m_IsRunStart = true;
        }

        if (m_State != null)
        {
            m_State.StateUpdate();
        }
    }
}
