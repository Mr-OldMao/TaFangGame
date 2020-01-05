using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    private SceneStateControl controller = null;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    
    void Start()
    {
        controller = new SceneStateControl();
        //不加载场景，因为当前就是StartState场景
        controller.SetState(new StartState(controller),false);
    }
    
    void Update()
    {
        controller.StateUpdate();
    }
}
