using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostText : MonoBehaviour
{
    public Level3ChatBubble panel;
    public int h;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (h == 0)
            {
                panel.gameObject.SetActive(true);
                h = 1;
            }
            
        }
    }
}
