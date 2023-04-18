using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    float x;
    float y;

    public bool canMove = true;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        InputManager();
    }
    private void FixedUpdate()
    {
        if (canMove)
        {
            MovementManager();
        }
       
    }

    private void InputManager()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
    }

    private void MovementManager()
    {
        rb.velocity = new Vector2(x * speed, y * speed);
    }

}
