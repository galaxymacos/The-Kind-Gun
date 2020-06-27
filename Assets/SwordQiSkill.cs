using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SwordQiSkill : Skill
{
    public override void Use()
    {
        var projectile = Instantiate(GameAssets.i.SwordQi,transform.position, Quaternion.identity);
        projectile.GetComponentInChildren<IOwnable>()?.SetOwner(owner);
    }
}