using System;
using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class PlayerSkillCaster : MonoBehaviour
{
    LuaState lua = null;
    LuaFunction luaFunc = null;
    private string strLog = "";
    
    
    // Start is called before the first frame update
    void Start()
    {
        // lua = new LuaState();
        // lua.Start();
        // LuaBinder.Bind(lua); 
        // string luaPath = Application.dataPath + "Scripts/Lua";
        // lua.AddSearchPath(luaPath);
        // lua.DoFile("NormalSkill.lua");
        // lua.DoFile("Skill1.lua");
        // lua.DoFile("Skill2.lua");
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // CallFunc("NormalSkill.Use", gameObject);
            CharacterData.Instance.NormalSkill.Use();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            // CallFunc("Skill1.Use", gameObject);
            CharacterData.Instance.MainSkill.Use();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            // CallFunc("Skill2.Use", gameObject);
            CharacterData.Instance.SecondSkill.Use();
        }
    }

    void CallFunc(string func, GameObject obj)
    {
        luaFunc = lua.GetFunction(func);
        luaFunc.Call(obj);
        luaFunc.Dispose();
        luaFunc = null;
    }

    private void OnApplicationQuit()
    {
        // lua.Dispose();
        // lua = null;
    }
}
