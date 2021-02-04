using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorpressureplate : MonoBehaviour
{
    public GameObject doorGameObject;
    private Idoor door;
    private float timer;
    public Sprite greenbutton;
    public Sprite opendoor;
    
    
    private void Awake()
    {
        //door = doorGameObject.GetComponent<Idoor>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            //door.OpenDoor();
            this.gameObject.GetComponent<SpriteRenderer>().sprite = greenbutton;
            doorGameObject.gameObject.GetComponent<SpriteRenderer>().sprite = opendoor;
            doorGameObject.gameObject.GetComponent<Collider2D>().enabled = false;
        }
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            
            timer = 5f;
        }
    }

    private void Update()
    {
        
        if(timer > 0f)
        {
            timer -= Time.deltaTime;
            if(timer <= 0f)
            {
                //door.CloseDoor();
                
            }
        }
    }
}
