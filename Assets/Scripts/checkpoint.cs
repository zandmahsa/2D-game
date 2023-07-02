using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
	private player p;
	
    void Start()
    {
        p = FindObjectOfType<player>();
    }
	
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.transform.tag == "Player")//find the player and go to the last position of player
		{
			
			p.startx = this.transform.position.x;
			p.starty = this.transform.position.y;
			
		}
	}
	
	

    
}
