using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTutorial : MonoBehaviour
{

    private PlayerTutorial theTPlayer;

    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;
    public GameObject Collider;

    public bool doorOpen, waitingToOpen;

    // Start is called before the first frame update
    void Start()
    {
        theTPlayer = FindObjectOfType<PlayerTutorial>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToOpen)
        {
            if (Vector3.Distance(theTPlayer.followingTKey.transform.position, transform.position) < 0.01f)
            {
                waitingToOpen = false;

                doorOpen = true;
                theSR.sprite = doorOpenSprite;
                theTPlayer.followingTKey.gameObject.SetActive(false);
                theTPlayer.followingTKey = null;
                Destroy(Collider);

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (theTPlayer.followingTKey != null)
            {
                theTPlayer.followingTKey.followTarget = transform;
                waitingToOpen = true;

            }
        }
    }
}
