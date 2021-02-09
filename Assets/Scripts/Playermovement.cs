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
    private GameObject[] powerup;
    private GameObject[] crates;
    public float timer;

    void Start()
    {
        powerup = GameObject.FindGameObjectsWithTag("Powerup");
        crates = GameObject.FindGameObjectsWithTag("Crate");
    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        rb.velocity = new Vector2(movement.x, movement.y);
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);

        transform.position = transform.position + movement * movespeed * Time.deltaTime;


        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                for (int i = 0; i < powerup.Length; i++)
                {
                    powerup[i].SetActive(true);
                }
                for (int j = 0; j < crates.Length; j++)
                {
                    Rigidbody2D rigidbody = crates[j].GetComponent<Rigidbody2D>();
                    rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
                }
            }
         }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Powerup"))
        {
            for (int i = 0; i < powerup.Length; i++)
            {
                powerup[i].SetActive(false);
            }
            for (int j = 0; j < crates.Length; j++)
            {
                Rigidbody2D rigidbody = crates[j].GetComponent<Rigidbody2D>();
                rigidbody.constraints = RigidbodyConstraints2D.None;
                rigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
                rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
            }
            timer = 10f;
        }
    }
}
