using System;
using UnityEngine;

public class SwordQi : MonoBehaviour, IOwnable
{
    private Vector3 flyDir;
    [SerializeField] private float speed = 20f;
    [SerializeField] private int damage = 10;
    private GameObject _owner;
    
    private void Awake()
    {
        Vector3 mousePos = UtilityClass.mouseWorldPos;
        flyDir = (mousePos - transform.position).normalized;
        flyDir.z = 0;
        transform.rotation = Quaternion.FromToRotation(Vector3.right, flyDir);
        
    }

    private void Update()
    {
        transform.Translate(flyDir * (speed * Time.deltaTime), Space.World);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.root.gameObject == _owner)
            return;
        
        var iTakeDamage = other.transform.root.GetComponentInChildren<ITakeDamage>();
        iTakeDamage?.TakeDamage(damage);
    }

    public void SetOwner(GameObject owner)
    {
        _owner = owner;
    }
}

/// <summary>
/// This class is for object who has an owner
/// </summary>
public interface IOwnable
{
    void SetOwner(GameObject owner);
}