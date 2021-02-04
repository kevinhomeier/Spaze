using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float movespeed;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;

    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
}
