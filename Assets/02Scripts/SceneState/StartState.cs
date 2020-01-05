using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

class StartState : ISceneState
{
    //本类构造方法 并调用基类的构造方法
    public StartState(SceneStateControl controller) : base("01StartState", controller)
    {
      
    }

    private Image m_Logo;
    private float m_ChangeSpeed = 2f; //logo的动画变换速度
    private float m_CurTimer =0;
    private float m_TargeTime = 3f;
    public override void StateStart()
    {
        m_Logo = GameObject.Find("Img_Logo").GetComponent<Image>();
        m_Logo.color = Color.black;
        Debug.Log("0000");
    }

    public override void StateUpdate()
    {
        m_Logo.color = Color.Lerp(m_Logo.color, Color.white, Time.deltaTime * m_ChangeSpeed);
        //设计：两秒后切换页面
        m_CurTimer += Time.deltaTime;
        if (m_CurTimer >= m_TargeTime)
        {
            m_controller.SetState(new MainMenuState(m_controller));
        }
    }
}

