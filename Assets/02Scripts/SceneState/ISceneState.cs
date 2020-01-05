using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISceneState
{

    private string m_SceneName;
    protected SceneStateControl m_controller;           //状态拥有者


    public ISceneState(string sceneName, SceneStateControl controller)
    {
        m_SceneName = sceneName;
        m_controller = controller;
    }

    public string SceneName
    {
        get { return m_SceneName; }
    }

    public virtual void StateStart() { }
    public virtual void StateEnd() { }
    public virtual void StateUpdate() { }
}
