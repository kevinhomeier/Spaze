using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level3ChatBubble : MonoBehaviour
{
    
    public TextMeshProUGUI textMeshPro;

    public string[] sentences;
    public int h;
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
            if (h == 0 || h == 2 || h == 4 || h == 6 || h == 9)
            {
                string sentence = sentences[h];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", true);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", false);
                myImageComponent.GetComponent<Animator>().SetBool("GhostStolen", false);
                myImageComponent.GetComponent<Animator>().SetBool("Snuzz", false);
                h++;
            }
            else if (h == 1 || h == 3 || h == 5 | h == 7 || h == 8)
            {
                string sentence = sentences[h];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", true);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", false);
                myImageComponent.GetComponent<Animator>().SetBool("Snuzz", false);
                h++;
            }
            else if (h == 10)
            {
                string sentence = sentences[h];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", true);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", false);
                myImageComponent.GetComponent<Animator>().SetBool("Snuzz", false);
                col.SetActive(false);
            }
            else if (h == 11)
            {
                string sentence = sentences[h];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("GhostStolen", true);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", false);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", false);
                myImageComponent.GetComponent<Animator>().SetBool("Snuzz", false);
                h++;
            }
            else if (h == 12)
            {
                string sentence = sentences[h];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", true);
                myImageComponent.GetComponent<Animator>().SetBool("GhostStolen", false);
                myImageComponent.GetComponent<Animator>().SetBool("Ghost", false);
                myImageComponent.GetComponent<Animator>().SetBool("Snuzz", false);
                h++;
            }
            else if(h==13)
            {
                gameObject.SetActive(false);
            }

        }
    }

    public void SetUp(string text)
    {
        textMeshPro = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textMeshPro.SetText(text);
    }



}
