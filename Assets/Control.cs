using UnityEngine;
using LuaInterface;
public class Control : MonoBehaviour {
    LuaState lua = null;
    LuaFunction luaFunc = null;
    void Start () {
        new LuaResLoader();
        lua = new LuaState();
        lua.Start();
        LuaBinder.Bind(lua);
        string luaPath = Application.dataPath + "/Scripts/Lua";//注意这里的文件位置
        lua.AddSearchPath(luaPath);
        lua.DoFile("Control.lua");
        CallFunc("Control.Start", gameObject);//调用lua中的this.Start函数
    }
    void Update () {
        CallFunc("Control.Update", gameObject);////调用lua中的this.Update函数
    }
    private void OnApplicationQuit()
    {
        lua.Dispose();
        lua = null;
    }
    void CallFunc(string func, GameObject obj){
        luaFunc = lua.GetFunction(func);
        luaFunc.Call(obj);
        luaFunc.Dispose();
        luaFunc = null;
    }
}