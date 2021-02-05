using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedpowerup : MonoBehaviour
{
    public float timedpowerup = 4f;
    public float multiplier = 2f;
    public bool speed = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
            speed = true;
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        
        Playermovement playerscript = player.GetComponent<Playermovement>();
        playerscript.movespeed *= multiplier;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(timedpowerup);
        playerscript.movespeed /= multiplier;
        Destroy(gameObject);
        speed = false;
    }
}
