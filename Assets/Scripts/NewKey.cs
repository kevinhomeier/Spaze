using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewKey : MonoBehaviour
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
        if(isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.tag == "Player")
        {
            if(!isFollowing)
            {
                Playermovement thePlayer = Other.GetComponent<Playermovement>();

                followTarget = thePlayer.keyFollowPoint;
                isFollowing = true;
                thePlayer.followingKey = this;
            }
        }
    }
}
