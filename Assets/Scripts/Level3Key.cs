using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Key : MonoBehaviour
{

    private bool isFollowing;

    public float followSpeed;

    public Transform followTarget;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
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
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                followTarget = thePlayer.key3FollowPoint;
                isFollowing = true;
                thePlayer.following3Key = this;
            }
        }
    }
}
