using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// 战斗状态
/// </summary>
class BattleState : ISceneState
{
    //private GameFacade m_Facade; //外观模式的引用

    public BattleState(  SceneStateControl controller) : base("03BattleState", controller)
    { 
    }

    public override void StateStart()
    {
        GameFacade.GetInstance().Init();
    }

    public override void StateUpdate()
    {
        GameFacade.GetInstance().Update();
    }
    public override void StateEnd()
    {
        if (GameFacade.GetInstance().isGameOver)
        {
            m_controller.SetState(new MainMenuState(m_controller));
        }
        GameFacade.GetInstance().Release();
    }

}

