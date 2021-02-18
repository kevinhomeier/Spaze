using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI textMeshPro;
    
    public string[] sentences;
    private int i;
    public Image myImageComponent;
    public Sprite opendoor;
    public GameObject door;

    public void Start()
    {
        gameObject.SetActive(false);
    }

    private void Awake()
    {
        timer = 5f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(i == 0 || i ==2 || i == 4 || i == 7)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", true);
                i++;
            }else if(i == 1 || i == 3 || i == 5 || i == 6 || i ==8)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.GetComponent<Animator>().SetBool("Billy", false);
                i++;
            }
            else if (i == 9)
            {
                door.gameObject.GetComponent<SpriteRenderer>().sprite = opendoor;
                door.gameObject.GetComponent<Collider2D>().enabled = false;
            }

            

        }
    }
    


    public void SetUp(string text)
    {
        textMeshPro = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textMeshPro.SetText(text);
    }
    
}
