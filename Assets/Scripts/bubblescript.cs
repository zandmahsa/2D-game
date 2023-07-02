using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblescript : MonoBehaviour
{
    [SerializeField]
    float speed;

    [SerializeField]
    int damage;

    [SerializeField]
    float timetodestroy= 0.5f;

    public void startshoot(bool isfacingleft)
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();

        if(isfacingleft)
        {
            rb2d.velocity = new Vector2(-speed, 0);
        }
        else
        {
           rb2d.velocity = new Vector2(speed, 0); 
        }
        
        Destroy(gameObject, timetodestroy);

    }
}
