using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level3ChatBubble : MonoBehaviour
{
    
    public TextMeshProUGUI textMeshPro;

    public string[] sentences;
    public int i;
    public Image myImageComponent;
    public GameObject col;
    public PlayerLvl3 player;

    public void Start()
    {
        gameObject.SetActive(false);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (i == 0 || i == 2 || i == 4 || i == 6 || i == 9)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", true);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", false);
                myImageComponent.GetComponent<Animator>().SetBool("GhostStolen", false);
                i++;
            }
            else if (i == 1 || i == 3 || i == 5 | i == 7 || i == 8)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", true);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", false);
                i++;
            }
            else if (i == 10)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", true);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", false);
                col.SetActive(false);
            }
            else if (i == 11)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("GhostStolen", true);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", false);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", false);
                i++;
            }
            else if (i == 12)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", true);
                myImageComponent.GetComponent<Animator>().SetBool("GhostStolen", false);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", false);
                player.timer = 5;
            }


        }
    }

    public void SetUp(string text)
    {
        textMeshPro = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textMeshPro.SetText(text);
    }



}
