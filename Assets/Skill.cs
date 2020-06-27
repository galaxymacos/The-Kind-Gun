using UnityEngine;

public abstract class Skill: MonoBehaviour
{
    public GameObject owner;
    public abstract void Use();
}