using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speedpowerup : MonoBehaviour
{
    private float timedpowerup = 10f;
    private float multiplier = 2f;
    public bool speed = false;
    public float timer;
    public Level3ChatBubble panel;
    public Image myImageComponent;
    public int j;
    private float timer2;

    void OnTriggerEnter2D(Collider2D other)
    {
        timer = 10f;
        timer2 = 3f;
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
            speed = true;
            if(j == 0)
            {
                panel.gameObject.SetActive(true);
                myImageComponent.GetComponent<Animator>().SetBool("Snuzz", true);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", false);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", false);
                myImageComponent.GetComponent<Animator>().SetBool("GhostStolen", false);
                panel.SetUp("Oh if ya didn't notice, that thing makes you faster. Only lasts a limited amount of time though.");
                j = 1;
            }
           
        }
    }

    IEnumerator Pickup(Collider2D player)
    {
        GameObject.Find("SpeedAudio").GetComponent<AudioSource>().Play();
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
        if (timer2 > 0f)
        {
            timer2 -= Time.deltaTime;
            if (timer2 <= 0f)
            {
                panel.gameObject.SetActive(false);
            }
        }
    }
}
