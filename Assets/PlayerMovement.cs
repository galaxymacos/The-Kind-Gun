using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer sr;

    [SerializeField] private float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // Update facing
        UpdateFacing();
        
        // Update movement
        UpdateMovement();
    }

    private void UpdateMovement()
    {
        var xInput = Input.GetAxisRaw("Horizontal");
        var yInput = Input.GetAxisRaw("Vertical");

        Vector2 moveVector = new Vector2(xInput, yInput);
            moveVector = moveVector.normalized;
            GetComponent<Animator>().SetFloat("Speed", moveVector.magnitude);
            transform.Translate(moveVector * (moveSpeed * Time.deltaTime));

        

    }

    private void UpdateFacing()
    {
        // Get mouse position
        var v3 = UtilityClass.mouseWorldPos;
        if (v3.x > transform.position.x)
        {
            sr.flipX = false;
        }
        else
        {
            sr.flipX = true;
        }
    }
}

public static class UtilityClass
{
    public static Vector3 mouseWorldPos
    {
        get
        {
            var v3 = Input.mousePosition;
            v3.z = 10f;
            v3 = Camera.main.ScreenToWorldPoint(v3);
            return v3;
        }
    }

    public static Vector3 GetAimDirection(Vector3 original)
    {
        return (new Vector2(mouseWorldPos.x, mouseWorldPos.y) - new Vector2(original.x, original.y)).normalized;
    }
}
