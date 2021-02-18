using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private KeyType keyType;

    private bool isFollowing;

    public float followSpeed;

    public Transform followTarget;

    public enum KeyType
    {
        Red,
        Yellow,
        Blue
    }

    public KeyType GetKeyType()
    {
        return keyType;
    }

    void Update()
    {
        if (isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.tag == "Player")
        {
            if (!isFollowing)
            {
                PlayerLvl3 thePlayer = Other.GetComponent<PlayerLvl3>();
                followTarget = thePlayer.otherKeyFollowPoint;
                isFollowing = true;
                thePlayer.otherKey = this;
            }
        }
    }
}
