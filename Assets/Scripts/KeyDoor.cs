using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private Key.KeyType keyType;
    public Sprite open;
    public GameObject doorGameObject;
    private PlayerLvl3 thePlayer;

    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;

    public bool doorOpen, waitingToOpen;

    void Start()
    {
        thePlayer = FindObjectOfType<PlayerLvl3>();
    }


    public Key.KeyType GetKeyType()
    {
        return keyType;
    }

    

    void Update()
    {
        if (waitingToOpen)
        {
            if (Vector3.Distance(thePlayer.otherKey.transform.position, transform.position) < 0.01f)
            {
                waitingToOpen = false;

                doorOpen = true;
                theSR.sprite = doorOpenSprite;
                thePlayer.otherKey.gameObject.SetActive(false);
                thePlayer.otherKey = null;
                gameObject.GetComponent<BoxCollider2D>().enabled = false;

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (thePlayer.otherKey != null)
            {
                thePlayer.otherKey.followTarget = transform;
                waitingToOpen = true;

            }
        }
    }
}
