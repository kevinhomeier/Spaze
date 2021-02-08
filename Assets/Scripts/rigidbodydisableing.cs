using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigidbodydisableing : MonoBehaviour
{

    public Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            
        }
    }

}
