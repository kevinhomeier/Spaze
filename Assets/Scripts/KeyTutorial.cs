using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTutorial : MonoBehaviour
{

    private bool isFollowing;

    public float followSpeed;

    public Transform followTarget;

    public ChatBubble chatbubble;

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
                PlayerTutorial theTPlayer = Other.GetComponent<PlayerTutorial>();

                followTarget = theTPlayer.keyTFollowPoint;
                isFollowing = true;
                theTPlayer.followingTKey = this;
                chatbubble.SetUp("Now that you got the Key, try and find the door it belongs to. You might need to solve Puzzles along the way!");
            }
        }
    }
}
