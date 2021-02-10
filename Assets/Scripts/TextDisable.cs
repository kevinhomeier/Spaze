using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisable : MonoBehaviour
{
    public ChatBubble panel;
    public int i;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (i == 0)
            {
                panel.gameObject.SetActive(false);
            }
        }
    }
}
