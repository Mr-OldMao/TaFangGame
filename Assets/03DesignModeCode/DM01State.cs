using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 状态设计模式
/// 最简案例 2020-01-05 15:26:19
/// </summary>
public class DM01State : MonoBehaviour
{
    //测试
    public void Start()
    {
        Context context = new Context();
        context.SetState(new ConcreteStateA(context));
        context.Handle(5);
        context.Handle(20);
        context.Handle(15);
        context.Handle(8);
        context.Handle(100);


    }
}

public class Context
{
    private IState m_State;
    public void SetState(IState state)
    {
        m_State = state;
    }

    public void Handle(int arg)
    {
        m_State.Handle(arg);
    }
}



public interface IState
{
    void Handle(int args);
}

//A状态 
public class ConcreteStateA : IState
{
    private Context m_Context;
    public ConcreteStateA(Context Context)
    {
        m_Context = Context;
    }
    public void Handle(int args)
    {
        Debug.Log("状态A:" + args);
        //自动切换状态
        if (args > 10)
        {
            Debug.Log("当前数值：" + args + ">10 自动跳转状态B");
            m_Context.SetState(new ConcreteStateB(m_Context));
        }
    }
}

//B状态
public class ConcreteStateB : IState
{
    private Context m_Context;
    public ConcreteStateB(Context Context)
    {
        m_Context = Context;
    }
    public void Handle(int args)
    {
        Debug.Log("状态B:" + args);
        //自动切换状态
        if (args <= 10)
        {
            Debug.Log("当前数值：" + args + "<= 10 自动跳转状态A");
            m_Context.SetState(new ConcreteStateA(m_Context));
        }
    }
}