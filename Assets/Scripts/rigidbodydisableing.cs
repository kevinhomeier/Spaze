using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodydisableing : MonoBehaviour
{
    public bool active;
    private GameObject[] powerup;
    private GameObject[] crates;

    private void Start()
    {
        crates = GameObject.FindGameObjectsWithTag("Crate");
        for (int i = 0; i < crates.Length; i++)
        {
            Rigidbody2D rigidbody = crates[i].GetComponent<Rigidbody2D>();
            rigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        powerup = GameObject.FindGameObjectsWithTag("Powerup");
        for (int i = 0; i < powerup.Length; i++)
        {
            powerup[i].SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(active != true)
        { 
            powerup = GameObject.FindGameObjectsWithTag("Powerup");
            crates = GameObject.FindGameObjectsWithTag("Crate");
            for (int i = 0; i < powerup.Length; i++)
            {
                powerup[i].SetActive(false);
            }
        }
    }
} 
