using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostText : MonoBehaviour
{
    public Level3ChatBubble panel;
    public int i;

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (i == 0)
            {
                panel.gameObject.SetActive(true);
                i = 1;
            }
            else if (i == 12)
            {
                panel.gameObject.SetActive(false);
            }
            
        }
    }
}
