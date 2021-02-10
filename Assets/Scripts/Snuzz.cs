using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Snuzz : MonoBehaviour
{

    private bool isFollowing;

    public float followSpeed;

    public Transform followTarget;

    public GameObject chatbubble;
    public GameObject panel;

    public float timer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing == true)
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

                followTarget = theTPlayer.snuzzFollowPoint;
                isFollowing = true;
                theTPlayer.followingSnuzz = this;
                timer = 5;
                panel.gameObject.SetActive(true);
            }
            
        }
    }
}

