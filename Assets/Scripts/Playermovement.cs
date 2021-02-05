using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movespeed;
    public Animator animator;
    public Transform keyFollowPoint;
    public NewKey followingKey;


    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        rb.velocity = new Vector2(movement.x, movement.y);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        transform.position = transform.position + movement * movespeed * Time.deltaTime;
    }

}
