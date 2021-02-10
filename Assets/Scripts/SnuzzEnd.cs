using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnuzzEnd : MonoBehaviour
{

    public PlayerTutorial theTPlayer;
    public string text;
    public ChatBubble panel;

    // Start is called before the first frame update
    void Start()
    {
        theTPlayer = FindObjectOfType<PlayerTutorial>();
    }

    // Update is called once per frame
    void Update()
    {
        if (theTPlayer != null && theTPlayer.followingSnuzz != null && Vector3.Distance(theTPlayer.followingSnuzz.transform.position, transform.position) < 0.01f)
        {
            theTPlayer.followingSnuzz = null;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (theTPlayer.followingSnuzz != null)
            {
                theTPlayer.followingSnuzz.followTarget = transform;
                panel.gameObject.SetActive(true);
                panel.SetUp(text);
            }
        }
    }
}
