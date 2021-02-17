using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : MonoBehaviour
{
    [SerializeField] private Key.KeyType keyType;
    public Sprite open;
    public GameObject doorGameObject;

    public Key.KeyType GetKeyType()
    {
        return keyType;
    }

    public void OpenDoor()
    {
        doorGameObject.gameObject.GetComponent<SpriteRenderer>().sprite = open;
        doorGameObject.gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
