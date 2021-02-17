using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level3ChatBubble : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI textMeshPro;

    public Sprite ghost;
    public Sprite ghostStolen;
    public Sprite billy;
    public string[] sentences;
    public int i;
    public Image myImageComponent;
    public GameObject col;

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
            if (i == 0 || i == 2 || i == 4 || i == 6 || i == 9 || i ==12)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.sprite = billy;
                i++;
            }
            else if (i == 1 || i == 3 || i == 5 | i == 7 || i == 8)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.sprite = ghost;
                i++;
            }
            else if (i == 11)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.sprite = ghostStolen;
                i++;
            }
            else if (i == 10)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.sprite = ghost;
                col.SetActive(false);
            }
            
        }
    }

    public void SetUp(string text)
    {
        textMeshPro = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textMeshPro.SetText(text);
    }



}
