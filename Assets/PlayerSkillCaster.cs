using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillCaster : MonoBehaviour
{
    [SerializeField] private Skill mainSkill;

    [SerializeField] private Skill secondSkill;

    [SerializeField] private Skill normalSkill;
    // Start is called before the first frame update
    void Start()
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
