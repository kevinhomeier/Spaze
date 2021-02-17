using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ghost : MonoBehaviour
{
    public Animator animator;
    public Level3ChatBubble panel;
    public Sprite ghostStolen;
    public Image myImageComponent;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetBool("Stolen", true);
            myImageComponent.sprite = ghostStolen;
            panel.SetUp("Hey!");
            panel.i = 11;
        }
    }

    
}
