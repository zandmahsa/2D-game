using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform destination;// destination for teleport
    private player p;

    private void Awake()
    {
        p = FindObjectOfType<player>();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            if(Vector2.Distance(p.transform.position, transform.position) > 0.1f)// if the distance was bigger than 0.1f change the position
            {
                p.transform.position = destination.transform.position;
            }
        }
            
    }
}
