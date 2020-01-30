using UnityEngine;
/// <summary>
/// 桥接模式简单案例
/// 背景：某个图形使用某个引擎来渲染
/// 使用了多态思想
/// </summary>
class DM02Bridge : MonoBehaviour
{
    void Start()
    {
        //Test
        IRenderEngine renderEngine = new DirectX();

        Cube cube = new Cube(renderEngine);
        cube.Draw();
        Sphere sphere = new Sphere(renderEngine);
        sphere.Draw();

    } 
}

//图形接口（用于存放各种图形的公共属性或方法）
public class IPattern
{
    public string name;  //图形名称
    public IRenderEngine renderEngine; //渲染引擎接口

    public IPattern(IRenderEngine re)
    {
        renderEngine = re;
    }

    public void Draw()
    {
        renderEngine.Render(name);
    }
}
public class Cube : IPattern
{
    public Cube(IRenderEngine re) :base(re)
    {
        name = "Cube";
    }
}
public class Sphere : IPattern
{
    public Sphere(IRenderEngine re) : base(re)
    {
        name = "Sphere";
    }
}

//渲染引擎接口 
public abstract class IRenderEngine
{
    public abstract void Render(string name);
}
//OpenGL引擎
public class OpenGL : IRenderEngine
{
    public override void Render(string name)
    {
        Debug.Log("调用了OpenGL渲染引擎，渲染了图形：" + name);
    }
}
//DirectX引擎
public class DirectX : IRenderEngine
{
    public override void Render(string name)
    {
        Debug.Log("调用了DirectX渲染引擎，渲染了图形：" + name);
    }
}

