using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChatBubble : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI textMeshPro;

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
        
            
                SetUp("To find it you must press specific buttons that only correspond with their same - colored  doors in order to go through paths.");
               
            
        
        
    }

    


    public void SetUp(string text)
    {
        textMeshPro = transform.Find("Text").GetComponent<TextMeshProUGUI>();
        textMeshPro.SetText(text);
    }
    
}
