using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// 主按钮状态
/// </summary>
class MainMenuState : ISceneState
{
    public MainMenuState(SceneStateControl controller) : base("02MainMenuState", controller)
    {
    }


    public override void StateStart()
    {
        GameObject.Find("Btn_StartGame").GetComponent<Button>().onClick.AddListener(() =>
        { m_controller.SetState(new BattleState(m_controller)); }
        );
    }

    public override void StateUpdate()
    {

    }
}


