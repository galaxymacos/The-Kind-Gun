using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SwordQiSkill : Skill
{
    [SerializeField] private GameObject projectilePrefab;
    public override void Use()
    {
        
        var projectile = Instantiate(projectilePrefab,transform.position, Quaternion.identity);

    }
}