using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Door : MonoBehaviour
{

    private PlayerLvl3 thePlayer;

    public SpriteRenderer theSR;
    public Sprite doorOpenSprite;
    public GameObject Collider;

    public bool doorOpen, waitingToOpen;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<PlayerLvl3>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waitingToOpen)
        {
            if (Vector3.Distance(thePlayer.following3Key.transform.position, transform.position) < 0.01f)
            {
                waitingToOpen = false;

                doorOpen = true;
                theSR.sprite = doorOpenSprite;
                thePlayer.following3Key.gameObject.SetActive(false);
                thePlayer.following3Key = null;
                Destroy(Collider);

            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (thePlayer.following3Key != null)
            {
                thePlayer.following3Key.followTarget = transform;
                waitingToOpen = true;

            }
        }
    }
}
