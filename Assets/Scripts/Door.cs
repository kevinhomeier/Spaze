using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject doorGameObject;
    private Playermovement thePlayer;
    public BoxCollider2D anscol;
    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;

    public bool doorOpen, waitingToOpen;

    // Start is called before the first frame update
    void Start()
    {
        
        thePlayer = FindObjectOfType<Playermovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(waitingToOpen)
        {
            if(Vector3.Distance(thePlayer.followingKey.transform.position, transform.position) <0.01f)
            {
                waitingToOpen = false;
                if(doorOpen = true)
                {
                    anscol.isTrigger = true;
                }
                theSR.sprite = doorOpenSprite;
                thePlayer.followingKey.gameObject.SetActive(false);
                thePlayer.followingKey = null;
                
                
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            if (thePlayer.followingKey != null)
            {
                thePlayer.followingKey.followTarget = transform;
                waitingToOpen = true;
                
            }
        }
    }
}
