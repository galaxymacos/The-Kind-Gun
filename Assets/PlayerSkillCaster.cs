using System.Collections;
using System.Collections.Generic;
using LuaInterface;
using UnityEngine;

public class PlayerSkillCaster : MonoBehaviour
{
    LuaState lua = null;
    private string strLog = "";
    
    [SerializeField] private Skill mainSkill;
    [SerializeField] private Skill secondSkill;
    [SerializeField] private Skill normalSkill;
    // Start is called before the first frame update
    void Start()
    {
        Application.logMessageReceived += Log;
        lua = new LuaState();
        lua.Start();
    }

    private void Log(string condition, string stacktrace, LogType type)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            normalSkill.Use();
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainSkill.Use();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            secondSkill.Use();
        }
    }
}
