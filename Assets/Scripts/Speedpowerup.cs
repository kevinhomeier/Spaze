using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedpowerup : MonoBehaviour
{
    public float timedpowerup = 4f;
    public float multiplier = 2f;
    public bool speed = false;
    public float timer;

    void OnTriggerEnter2D(Collider2D other)
    {
        timer = 5f;
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
            speed = true;
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        
        PlayerLvl3 playerscript = player.GetComponent<PlayerLvl3>();
        playerscript.movespeed *= multiplier;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        yield return new WaitForSeconds(timedpowerup);
        playerscript.movespeed /= multiplier;
        
        speed = false;

    }

    private void Update()
    {

        if (timer > 0f)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                GetComponent<SpriteRenderer>().enabled = true;
                GetComponent<Collider2D>().enabled = true;

            }
        }
    }
}
