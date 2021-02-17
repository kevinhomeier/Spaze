using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level3ChatBubble : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI textMeshPro;

    public Sprite snuzz;
    public Sprite billy;
    public string[] sentences;
    private int i;
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
            if (i == 0 || i == 2 || i == 4 || i == 7)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.sprite = billy;
                i++;
            }
            else if (i == 1)
            {
                string sentence = sentences[i];
                SetUp(sentence);
                myImageComponent.sprite = snuzz;
                i++;
            }
            else if (i == 3)
                {
                    
                }


        }
    }

    public void SetUp(string text)
    {
        textMeshPro = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textMeshPro.SetText(text);
    }



}
