using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    private Rigidbody2D rb;
    private Vector2 movement;
    public bool isMove;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        if(GameManager.Instance.isGameOver == true)
        {
            movement.x = 0;
            movement.y = 0;
            isMove = false;
            return;
        }
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        isMove = movement.x != 0 || movement.y != 0;
    }

    void FixedUpdate()
    { 
        rb.velocity = movement.normalized * moveSpeed;
    }
}
