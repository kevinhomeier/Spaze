using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float speed;

    private void FixedUpdate()
    {
        //transform.position = Vector3.Lerp(transform.position, target.position + offset, Time.deltaTime * speed);
        transform.position = Vector3.MoveTowards(transform.position, Vector3.Lerp(transform.position, target.position + offset, speed * Time.fixedDeltaTime), speed * Time.fixedDeltaTime);
    }
    

}
