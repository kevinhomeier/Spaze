using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnuzzEnd : MonoBehaviour
{

    public Playermovement thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<Playermovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (thePlayer != null && thePlayer.followingSnuzz != null && Vector3.Distance(thePlayer.followingSnuzz.transform.position, transform.position) < 0.01f)
        {
            thePlayer.followingSnuzz = null;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (thePlayer.followingSnuzz != null)
            {
                thePlayer.followingSnuzz.followTarget = transform;
            }
        }
    }
}
